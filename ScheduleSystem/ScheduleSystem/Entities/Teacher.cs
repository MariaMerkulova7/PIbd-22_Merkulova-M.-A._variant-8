using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities
{
    public class Teacher
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string MiddleName { get; private set; } = string.Empty;
        public string Department { get; private set; } = string.Empty;

        public static Teacher CreateEntity(int id, string firstName, string lastName, string middleName, string department)
        {
            return new Teacher
            {
                Id = id,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                MiddleName = middleName ?? string.Empty,
                Department = department ?? string.Empty
            };
        }
    }
}
