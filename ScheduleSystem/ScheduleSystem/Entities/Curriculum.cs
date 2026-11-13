using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities
{
    public class Curriculum
    {
        public int Id { get; private set; }
        public int GroupId { get; private set; }
        public int DisciplineId { get; private set; }
        public int TeacherId { get; private set; }
        public int Course { get; private set; }
        public int LectureHours { get; private set; }
        public int LaboratoryHours { get; private set; }

        public static Curriculum CreateOperation(int id, int groupId, int disciplineId, int teacherId, int course, int lectureHours, int laboratoryHours)
        {
            return new Curriculum
            {
                Id = id,
                GroupId = groupId,
                DisciplineId = disciplineId,
                TeacherId = teacherId,
                Course = course,
                LectureHours = lectureHours,
                LaboratoryHours = laboratoryHours
            };
        }
    }
}
