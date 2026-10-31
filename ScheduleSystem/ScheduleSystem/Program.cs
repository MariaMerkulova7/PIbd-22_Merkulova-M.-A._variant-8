using ScheduleSystem.Repositories;
using ScheduleSystem.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ScheduleSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрируем справочники
            container.RegisterType<IAudienceRepository, AudienceRepository>(new TransientLifetimeManager());
            container.RegisterType<IStudentGroupRepository, StudentGroupRepository>(new TransientLifetimeManager());
            container.RegisterType<ITeacherRepository, TeacherRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());

            // Регистрируем связку многие-ко-многим
            container.RegisterType<ITeacherDisciplineRepository, TeacherDisciplineRepository>(new TransientLifetimeManager());

            // Регистрируем операции
            container.RegisterType<ICurriculumRepository, CurriculumRepository>(new TransientLifetimeManager());
            container.RegisterType<ILessonRepository, LessonRepository>(new TransientLifetimeManager());

            // Регистрируем формы для Аудиторий
            container.RegisterType<FormAudiences>();
            container.RegisterType<FormAudience>();

            return container;
        }
    }
}