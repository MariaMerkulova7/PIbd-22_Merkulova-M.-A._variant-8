using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class StudentGroup
    {
        public StudentGroup() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column("GroupName", TypeName = "varchar(50)")]
        public string GroupName { get; protected set; } = string.Empty;

        [Column("Course")]
        public int Course { get; protected set; }

        [Column("StudentCount")]
        public int StudentCount { get; protected set; }

        public static StudentGroup CreateEntity(int id, string groupName, int course, int studentCount) =>
            new() { Id = id, GroupName = groupName ?? string.Empty, Course = course, StudentCount = studentCount };
    }
}