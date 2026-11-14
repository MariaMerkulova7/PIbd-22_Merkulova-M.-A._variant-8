using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class TeacherDisciplineRepository : ITeacherDisciplineRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<TeacherDisciplineRepository> _logger;

        public TeacherDisciplineRepository(
            ScheduleDbContext context,
            ILogger<TeacherDisciplineRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void CreateTeacherDiscipline(TeacherDiscipline teacherDiscipline)
        {
            _logger.LogInformation("Добавление связи Преподаватель-Дисциплина: TeacherId={TeacherId}, DisciplineId={DisciplineId}",
                teacherDiscipline.TeacherId, teacherDiscipline.DisciplineId);

            IDbContextTransaction? transaction = null;
            try
            {
                // Начинаем транзакцию
                transaction = _context.Database.BeginTransaction();

                _context.TeacherDisciplines.Add(teacherDiscipline);
                _context.SaveChanges();

                // Фиксируем транзакцию
                transaction.Commit();
                _logger.LogInformation("Связь успешно добавлена");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении связи");
                transaction?.Rollback(); // Откатываем изменения при ошибке
                throw;
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public void DeleteTeacherDiscipline(int id)
        {
            _logger.LogInformation("Удаление связи с Id: {Id}", id);

            IDbContextTransaction? transaction = null;
            try
            {
                transaction = _context.Database.BeginTransaction();

                var td = _context.TeacherDisciplines.Find(id);
                if (td != null)
                {
                    _context.TeacherDisciplines.Remove(td);
                    _context.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении связи");
                transaction?.Rollback();
                throw;
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public TeacherDiscipline ReadTeacherDisciplineById(int id)
        {
            _logger.LogDebug("Поиск связи по Id: {Id}", id);
            try
            {
                return _context.TeacherDisciplines.AsNoTracking().FirstOrDefault(td => td.Id == id)
                    ?? throw new Exception("Связь не найдена");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при поиске связи");
                throw;
            }
        }

        public IEnumerable<TeacherDiscipline> ReadTeacherDisciplines()
        {
            _logger.LogDebug("Загрузка списка связей");
            try
            {
                return _context.TeacherDisciplines.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении списка связей");
                throw;
            }
        }

        public void UpdateTeacherDiscipline(TeacherDiscipline teacherDiscipline)
        {
            _logger.LogInformation("Обновление связи: TeacherId={TeacherId}, DisciplineId={DisciplineId}",
                teacherDiscipline.TeacherId, teacherDiscipline.DisciplineId);

            IDbContextTransaction? transaction = null;
            try
            {
                transaction = _context.Database.BeginTransaction();

                _context.TeacherDisciplines.Update(teacherDiscipline);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении связи");
                transaction?.Rollback();
                throw;
            }
            finally
            {
                transaction?.Dispose();
            }
        }
    }
}