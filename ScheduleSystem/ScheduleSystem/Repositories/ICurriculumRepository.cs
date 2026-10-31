using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface ICurriculumRepository
    {
        IEnumerable<Curriculum> ReadCurriculums();
        void CreateCurriculum(Curriculum curriculum);
        void DeleteCurriculum(int id);
    }
}
