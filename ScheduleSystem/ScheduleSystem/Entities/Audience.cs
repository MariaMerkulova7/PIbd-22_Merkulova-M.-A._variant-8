using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleSystem.Entities.Enums;

namespace ScheduleSystem.Entities
{
    public class Audience
    {
        public int Id { get; private set; }
        public string Number { get; private set; } = string.Empty;
        public int Capacity { get; private set; }
        public AudienceType AudienceType { get; private set; }

        public static Audience CreateEntity(int id, string number, int capacity, AudienceType audienceType)
        {
            return new Audience
            {
                Id = id,
                Number = number ?? string.Empty,
                Capacity = capacity,
                AudienceType = audienceType
            };
        }
    }
}
