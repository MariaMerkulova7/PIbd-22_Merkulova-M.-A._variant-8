using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities
{
    public class TeacherDiscipline
    {
        public int Id { get; private set; }
        public int TeacherId { get; private set; }
        public int DisciplineId { get; private set; }

        public static TeacherDiscipline CreateEntity(int id, int teacherId, int disciplineId)
        {
            return new TeacherDiscipline
            {
                Id = id,
                TeacherId = teacherId,
                DisciplineId = disciplineId
            };
        }
    }
}
