using Microsoft.Extensions.Logging;
using ScheduleSystem.Data;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class LessonRepository : ILessonRepository
    {
        private readonly ScheduleDbContext _context;
        private readonly ILogger<LessonRepository> _logger;

        public LessonRepository(
            ScheduleDbContext context,
            ILogger<LessonRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void CreateLesson(Lesson lesson)
        {
            _logger.LogInformation("Добавление занятия: AudienceId={AudienceId}, TeacherId={TeacherId}, DisciplineId={DisciplineId}, GroupId={GroupId}",
                lesson.AudienceId, lesson.TeacherId, lesson.DisciplineId, lesson.GroupId);
            try
            {
                _context.Lessons.Add(lesson);
                _context.SaveChanges();
                _logger.LogInformation("Занятие успешно добавлено");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении занятия");
                throw;
            }
        }

        public IEnumerable<Lesson> ReadLessons()
        {
            _logger.LogDebug("Загрузка списка занятий");
            try
            {
                return _context.Lessons.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении списка занятий");
                throw;
            }
        }
    }
}