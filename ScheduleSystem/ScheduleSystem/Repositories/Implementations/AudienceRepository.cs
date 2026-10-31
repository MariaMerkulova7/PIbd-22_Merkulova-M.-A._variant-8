using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class AudienceRepository : IAudienceRepository
    {
        public void CreateAudience(Audience audience) { }
        public void DeleteAudience(int id) { }
        public Audience ReadAudienceById(int id) => Audience.CreateEntity(0, string.Empty, 0, Entities.Enums.AudienceType.None);
        public IEnumerable<Audience> ReadAudiences() => [];
        public void UpdateAudience(Audience audience) { }
    }
}