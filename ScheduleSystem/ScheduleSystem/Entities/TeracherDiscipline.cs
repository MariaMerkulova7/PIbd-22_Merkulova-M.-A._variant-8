using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class TeacherDiscipline
    {
        public TeacherDiscipline() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [ForeignKey("Teacher")]
        public int TeacherId { get; protected set; }

        [Required]
        [ForeignKey("Discipline")]
        public int DisciplineId { get; protected set; }

        public static TeacherDiscipline CreateEntity(int id, int teacherId, int disciplineId) =>
            new() { Id = id, TeacherId = teacherId, DisciplineId = disciplineId };
    }
}