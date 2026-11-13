using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSystem.Entities
{
    public class StudentGroup
    {
        public int Id { get; private set; }
        public string GroupName { get; private set; } = string.Empty;
        public int Course { get; private set; }
        public int StudentCount { get; private set; }

        public static StudentGroup CreateEntity(int id, string groupName, int course, int studentCount)
        {
            return new StudentGroup
            {
                Id = id,
                GroupName = groupName ?? string.Empty,
                Course = course,
                StudentCount = studentCount
            };
        }
    }
}