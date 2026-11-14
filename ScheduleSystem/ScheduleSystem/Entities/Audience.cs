using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleSystem.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class Audience
    {
        public Audience() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column("Number", TypeName = "varchar(50)")]
        public string Number { get; protected set; } = string.Empty;

        [Column("Capacity")]
        public int Capacity { get; protected set; }

        [Column("AudienceType")]
        public AudienceType AudienceType { get; protected set; }

        public static Audience CreateEntity(int id, string number, int capacity, AudienceType audienceType) =>
            new() { Id = id, Number = number ?? string.Empty, Capacity = capacity, AudienceType = audienceType };
    }
}