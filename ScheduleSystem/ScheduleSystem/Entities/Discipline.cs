using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities
{
    public class Discipline
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;

        public static Discipline CreateEntity(int id, string name, string description)
        {
            return new Discipline
            {
                Id = id,
                Name = name ?? string.Empty,
                Description = description ?? string.Empty
            };
        }
    }
}
