using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class TeacherRepository : ITeacherRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<TeacherRepository> _logger;

        public TeacherRepository(ScheduleDbContext context, ILogger<TeacherRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _logger.LogInformation("Добавление преподавателя: {FullName}", $"{teacher.LastName} {teacher.FirstName}");
            try { _context.Teachers.Add(teacher); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при добавлении преподавателя"); throw; }
        }

        public void DeleteTeacher(int id)
        {
            _logger.LogInformation("Удаление преподавателя с Id: {Id}", id);
            try
            {
                var teacher = _context.Teachers.Find(id);
                if (teacher != null) { _context.Teachers.Remove(teacher); _context.SaveChanges(); }
            }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при удалении преподавателя"); throw; }
        }

        public Teacher ReadTeacherById(int id)
        {
            try { return _context.Teachers.Find(id) ?? throw new Exception("Преподаватель не найден"); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при поиске преподавателя"); throw; }
        }

        public IEnumerable<Teacher> ReadTeachers()
        {
            try { return _context.Teachers.ToList(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при чтении списка преподавателей"); throw; }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _logger.LogInformation("Обновление преподавателя: {FullName}", $"{teacher.LastName} {teacher.FirstName}");
            try { _context.Teachers.Update(teacher); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при обновлении преподавателя"); throw; }
        }
    }
}