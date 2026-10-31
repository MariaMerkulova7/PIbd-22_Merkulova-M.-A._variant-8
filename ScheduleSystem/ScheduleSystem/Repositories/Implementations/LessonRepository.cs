using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class LessonRepository : ILessonRepository
    {
        public void CreateLesson(Lesson lesson) { }
        public IEnumerable<Lesson> ReadLessons() => [];
    }
}
