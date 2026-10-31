using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleSystem.Entities.Enums;

namespace ScheduleSystem.Entities
{
    public class Lesson
    {
        public int Id { get; private set; }
        public int AudienceId { get; private set; }
        public int TeacherId { get; private set; }
        public int DisciplineId { get; private set; }
        public int GroupId { get; private set; }
        public DateTime LessonDate { get; private set; }
        public TimeSpan LessonTime { get; private set; }
        public LessonType LessonType { get; private set; }

        public static Lesson CreateOperation(int id, int audienceId, int teacherId, int disciplineId, int groupId, TimeSpan lessonTime, LessonType lessonType)
        {
            return new Lesson
            {
                Id = id,
                AudienceId = audienceId,
                TeacherId = teacherId,
                DisciplineId = disciplineId,
                GroupId = groupId,
                LessonDate = DateTime.Now,
                LessonTime = lessonTime,
                LessonType = lessonType
            };
        }
    }
}
