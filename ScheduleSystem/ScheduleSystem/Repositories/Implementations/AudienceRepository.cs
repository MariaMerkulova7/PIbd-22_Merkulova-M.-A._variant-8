using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class AudienceRepository : IAudienceRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<AudienceRepository> _logger;

        public AudienceRepository(ScheduleDbContext context, ILogger<AudienceRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void CreateAudience(Audience audience)
        {
            _logger.LogInformation("Добавление аудитории: {Number}", audience.Number);
            try
            {
                _context.Audiences.Add(audience);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении аудитории");
                throw;
            }
        }

        public void DeleteAudience(int id)
        {
            _logger.LogInformation("Удаление аудитории с Id: {Id}", id);
            try
            {
                var audience = _context.Audiences.Find(id);
                if (audience != null)
                {
                    _context.Audiences.Remove(audience);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении аудитории");
                throw;
            }
        }

        public Audience ReadAudienceById(int id)
        {
            _logger.LogDebug("Поиск аудитории по Id: {Id}", id);
            try
            {
                return _context.Audiences.Find(id) ?? throw new Exception("Аудитория не найдена");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при поиске аудитории");
                throw;
            }
        }

        public IEnumerable<Audience> ReadAudiences()
        {
            _logger.LogDebug("Загрузка списка аудиторий");
            try
            {
                return _context.Audiences.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении списка аудиторий");
                throw;
            }
        }

        public void UpdateAudience(Audience audience)
        {
            _logger.LogInformation("Обновление аудитории: {Number}", audience.Number);
            try
            {
                _context.Audiences.Update(audience);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении аудитории");
                throw;
            }
        }
    }
}