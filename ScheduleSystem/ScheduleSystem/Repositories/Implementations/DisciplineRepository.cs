using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class DisciplineRepository : IDisciplineRepository
    {
        public void CreateDiscipline(Discipline discipline) { }
        public void DeleteDiscipline(int id) { }
        public Discipline ReadDisciplineById(int id) => Discipline.CreateEntity(0, string.Empty, string.Empty);
        public IEnumerable<Discipline> ReadDisciplines() => [];
        public void UpdateDiscipline(Discipline discipline) { }
    }
}