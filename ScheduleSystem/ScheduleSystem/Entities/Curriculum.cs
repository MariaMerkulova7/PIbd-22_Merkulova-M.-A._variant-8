using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleSystem.Entities
{
    public class Curriculum
    {
        public Curriculum() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [ForeignKey("StudentGroup")]
        public int GroupId { get; protected set; }

        [Required]
        [ForeignKey("Discipline")]
        public int DisciplineId { get; protected set; }

        [Required]
        [ForeignKey("Teacher")]
        public int TeacherId { get; protected set; }

        [Column("Course")]
        public int Course { get; protected set; }

        [Column("LectureHours")]
        public int LectureHours { get; protected set; }

        [Column("LaboratoryHours")]
        public int LaboratoryHours { get; protected set; }

        public static Curriculum CreateOperation(int id, int groupId, int disciplineId, int teacherId, int course, int lectureHours, int laboratoryHours) =>
            new() { Id = id, GroupId = groupId, DisciplineId = disciplineId, TeacherId = teacherId, Course = course, LectureHours = lectureHours, LaboratoryHours = laboratoryHours };
    }
}