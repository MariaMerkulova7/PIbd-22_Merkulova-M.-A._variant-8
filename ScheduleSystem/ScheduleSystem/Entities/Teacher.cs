using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class Teacher
    {
        public Teacher() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column("FirstName", TypeName = "varchar(50)")]
        public string FirstName { get; protected set; } = string.Empty;

        [Required]
        [Column("LastName", TypeName = "varchar(50)")]
        public string LastName { get; protected set; } = string.Empty;

        [Column("MiddleName", TypeName = "varchar(50)")]
        public string? MiddleName { get; protected set; }

        [Column("Department", TypeName = "varchar(100)")]
        public string? Department { get; protected set; }

        public static Teacher CreateEntity(int id, string firstName, string lastName, string? middleName, string? department) =>
            new() { Id = id, FirstName = firstName ?? string.Empty, LastName = lastName ?? string.Empty, MiddleName = middleName, Department = department };
    }
}