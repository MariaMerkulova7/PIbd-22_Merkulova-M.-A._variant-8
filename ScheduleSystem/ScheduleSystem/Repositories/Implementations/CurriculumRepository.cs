using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class CurriculumRepository : ICurriculumRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<CurriculumRepository> _logger;

        public CurriculumRepository(
            ScheduleDbContext context,
            ILogger<CurriculumRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void CreateCurriculum(Curriculum curriculum)
        {
            _logger.LogInformation("Добавление учебного плана: GroupId={GroupId}, DisciplineId={DisciplineId}, TeacherId={TeacherId}",
                curriculum.GroupId, curriculum.DisciplineId, curriculum.TeacherId);
            try
            {
                _context.Curriculums.Add(curriculum);
                _context.SaveChanges();
                _logger.LogInformation("Учебный план успешно добавлен");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении учебного плана");
                throw;
            }
        }

        public void DeleteCurriculum(int id)
        {
            _logger.LogInformation("Удаление учебного плана с Id: {Id}", id);
            try
            {
                var curriculum = _context.Curriculums.Find(id);
                if (curriculum != null)
                {
                    _context.Curriculums.Remove(curriculum);
                    _context.SaveChanges();
                    _logger.LogInformation("Учебный план успешно удалён");
                }
                else
                {
                    _logger.LogWarning("Учебный план с Id={Id} не найден", id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении учебного плана");
                throw;
            }
        }

        public IEnumerable<Curriculum> ReadCurriculums()
        {
            _logger.LogDebug("Загрузка списка учебных планов");
            try
            {
                return _context.Curriculums.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении списка учебных планов");
                throw;
            }
        }
    }
}