using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class CurriculumRepository : ICurriculumRepository
    {
        public void CreateCurriculum(Curriculum curriculum) { }
        public void DeleteCurriculum(int id) { }
        public IEnumerable<Curriculum> ReadCurriculums() => [];
    }
}