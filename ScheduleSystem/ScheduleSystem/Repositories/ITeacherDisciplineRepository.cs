using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface ITeacherDisciplineRepository
    {
        IEnumerable<TeacherDiscipline> ReadTeacherDisciplines();
        TeacherDiscipline ReadTeacherDisciplineById(int id);
        void CreateTeacherDiscipline(TeacherDiscipline teacherDiscipline);
        void UpdateTeacherDiscipline(TeacherDiscipline teacherDiscipline);
        void DeleteTeacherDiscipline(int id);
    }
}