using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class DisciplineRepository : IDisciplineRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<DisciplineRepository> _logger;

        public DisciplineRepository(ScheduleDbContext context, ILogger<DisciplineRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void CreateDiscipline(Discipline discipline)
        {
            _logger.LogInformation("Добавление дисциплины: {Name}", discipline.Name);
            try { _context.Disciplines.Add(discipline); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при добавлении дисциплины"); throw; }
        }

        public void DeleteDiscipline(int id)
        {
            _logger.LogInformation("Удаление дисциплины с Id: {Id}", id);
            try
            {
                var discipline = _context.Disciplines.Find(id);
                if (discipline != null) { _context.Disciplines.Remove(discipline); _context.SaveChanges(); }
            }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при удалении дисциплины"); throw; }
        }

        public Discipline ReadDisciplineById(int id)
        {
            try
            {
                return _context.Disciplines.AsNoTracking().FirstOrDefault(d => d.Id == id)
                    ?? throw new Exception("Дисциплина не найдена");
            }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при поиске дисциплины"); throw; }
        }

        public IEnumerable<Discipline> ReadDisciplines()
        {
            try { return _context.Disciplines.ToList(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при чтении списка дисциплин"); throw; }
        }

        public void UpdateDiscipline(Discipline discipline)
        {
            _logger.LogInformation("Обновление дисциплины: {Name}", discipline.Name);
            try { _context.Disciplines.Update(discipline); _context.SaveChanges(); }
            catch (Exception ex) { _logger.LogError(ex, "Ошибка при обновлении дисциплины"); throw; }
        }
    }
}