using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities.Enums
{
    [Flags]
    public enum LessonType
    {
        None = 0,
        Lecture = 1,
        Laboratory = 2,
        Practice = 4
    }
}
