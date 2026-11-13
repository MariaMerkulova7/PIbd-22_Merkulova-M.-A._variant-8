using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface IAudienceRepository
    {
        IEnumerable<Audience> ReadAudiences();
        Audience ReadAudienceById(int id);
        void CreateAudience(Audience audience);
        void UpdateAudience(Audience audience);
        void DeleteAudience(int id);
    }
}
