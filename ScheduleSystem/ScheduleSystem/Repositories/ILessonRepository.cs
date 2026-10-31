using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface ILessonRepository
    {
        IEnumerable<Lesson> ReadLessons();
        void CreateLesson(Lesson lesson);
    }
}
