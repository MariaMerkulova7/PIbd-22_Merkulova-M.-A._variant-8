using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class Discipline
    {
        public Discipline() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column("Name", TypeName = "varchar(100)")]
        public string Name { get; protected set; } = string.Empty;

        [Column("Description", TypeName = "varchar(500)")]
        public string? Description { get; protected set; }

        public static Discipline CreateEntity(int id, string name, string? description) =>
            new() { Id = id, Name = name ?? string.Empty, Description = description };
    }
}