using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Forms;
using ScheduleSystem.Repositories;
using ScheduleSystem.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace ScheduleSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Настраиваем Serilog из appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            try
            {
                Log.Information("Приложение запущено");
                Application.Run(CreateContainer().Resolve<MainForm>());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Приложение завершено с ошибкой");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрация DbContext
            container.RegisterType<ScheduleDbContext>(
                new TransientLifetimeManager(),
                new InjectionFactory(_ =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<ScheduleDbContext>();
                    optionsBuilder.UseNpgsql(
                        "Host=localhost;Port=5432;Database=schedule_db;Username=postgres;Password=qwerty");
                    return new ScheduleDbContext(optionsBuilder.Options);
                }));

            // Регистрация LoggerFactory для Serilog
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog(Log.Logger);
            });
            container.RegisterInstance<ILoggerFactory>(loggerFactory);

            // Регистрация ILogger<T> — через обобщённый метод
            container.RegisterType(typeof(ILogger<>),
                new InjectionFactory((c, t, n) =>
                {
                    var genericArg = t.GetGenericArguments()[0];
                    var createLoggerMethod = typeof(LoggerFactoryExtensions)
                        .GetMethods()
                        .First(m => m.Name == "CreateLogger" && m.IsGenericMethodDefinition)
                        .MakeGenericMethod(genericArg);
                    return createLoggerMethod.Invoke(null, new object[] { loggerFactory });
                }));

            // Регистрация справочников (CRUD)
            container.RegisterType<IAudienceRepository, AudienceRepository>(new TransientLifetimeManager());
            container.RegisterType<IStudentGroupRepository, StudentGroupRepository>(new TransientLifetimeManager());
            container.RegisterType<ITeacherRepository, TeacherRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());

            // Регистрация связи многие-ко-многим
            container.RegisterType<ITeacherDisciplineRepository, TeacherDisciplineRepository>(new TransientLifetimeManager());

            // Регистрация операций
            container.RegisterType<ICurriculumRepository, CurriculumRepository>(new TransientLifetimeManager());
            container.RegisterType<ILessonRepository, LessonRepository>(new TransientLifetimeManager());

            // Регистрация форм
            container.RegisterType<FormAudience>();
            container.RegisterType<FormAudiences>();
            container.RegisterType<FormStudentGroup>();
            container.RegisterType<FormStudentGroups>();
            container.RegisterType<FormTeacher>();
            container.RegisterType<FormTeachers>();
            container.RegisterType<FormDiscipline>();
            container.RegisterType<FormDisciplines>();
            container.RegisterType<FormTeacherDiscipline>();
            container.RegisterType<FormTeacherDisciplines>();
            container.RegisterType<FormCurriculum>();
            container.RegisterType<FormCurriculums>();
            container.RegisterType<FormLesson>();
            container.RegisterType<FormLessons>();

            return container;
        }
    }
}