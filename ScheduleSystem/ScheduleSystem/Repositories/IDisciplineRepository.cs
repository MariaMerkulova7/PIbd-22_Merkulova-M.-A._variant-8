using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> ReadDisciplines();
        Discipline ReadDisciplineById(int id);
        void CreateDiscipline(Discipline discipline);
        void UpdateDiscipline(Discipline discipline);
        void DeleteDiscipline(int id);
    }
}
