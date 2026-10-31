using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class TeacherDisciplineRepository : ITeacherDisciplineRepository
    {
        public void CreateTeacherDiscipline(TeacherDiscipline teacherDiscipline) { }
        public void DeleteTeacherDiscipline(int id) { }
        public TeacherDiscipline ReadTeacherDisciplineById(int id) => TeacherDiscipline.CreateEntity(0, 0, 0);
        public IEnumerable<TeacherDiscipline> ReadTeacherDisciplines() => [];
        public void UpdateTeacherDiscipline(TeacherDiscipline teacherDiscipline) { }
    }
}