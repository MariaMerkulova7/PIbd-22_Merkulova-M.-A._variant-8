using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class StudentGroupRepository : IStudentGroupRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<StudentGroupRepository> _logger;

        public StudentGroupRepository(ScheduleDbContext context, ILogger<StudentGroupRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateStudentGroup(StudentGroup studentGroup)
        {
            _logger.LogInformation("Добавление группы: {GroupName}", studentGroup.GroupName);
            try { _context.StudentGroups.Add(studentGroup); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при добавлении группы"); throw; }
        }

        public void DeleteStudentGroup(int id)
        {
            _logger.LogInformation("Удаление группы с Id: {Id}", id);
            try
            {
                var group = _context.StudentGroups.Find(id);
                if (group != null) { _context.StudentGroups.Remove(group); _context.SaveChanges(); }
            }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при удалении группы"); throw; }
        }

        public StudentGroup ReadStudentGroupById(int id)
        {
            try { return _context.StudentGroups.Find(id) ?? throw new Exception("Группа не найдена"); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при поиске группы"); throw; }
        }

        public IEnumerable<StudentGroup> ReadStudentGroups()
        {
            try { return _context.StudentGroups.ToList(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при чтении списка групп"); throw; }
        }

        public void UpdateStudentGroup(StudentGroup studentGroup)
        {
            _logger.LogInformation("Обновление группы: {GroupName}", studentGroup.GroupName);
            try { _context.StudentGroups.Update(studentGroup); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при обновлении группы"); throw; }
        }
    }
}