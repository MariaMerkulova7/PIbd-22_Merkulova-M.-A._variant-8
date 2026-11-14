using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScheduleSystem.Entities.Enums;

namespace ScheduleSystem.Entities
{
    public class Lesson
    {
        public Lesson() { }

        [Key]
        public int Id { get; protected set; }

        [Required]
        [ForeignKey("Audience")]
        public int AudienceId { get; protected set; }

        [Required]
        [ForeignKey("Teacher")]
        public int TeacherId { get; protected set; }

        [Required]
        [ForeignKey("Discipline")]
        public int DisciplineId { get; protected set; }

        [Required]
        [ForeignKey("StudentGroup")]
        public int GroupId { get; protected set; }

        [Column("LessonDate", TypeName = "date")]
        public DateTime LessonDate { get; protected set; }

        [Column("LessonTime", TypeName = "time")]
        public TimeSpan LessonTime { get; protected set; }

        [Column("LessonType")]
        public LessonType LessonType { get; protected set; }

        public static Lesson CreateOperation(int id, int audienceId, int teacherId, int disciplineId, int groupId, TimeSpan lessonTime, LessonType lessonType) =>
            new() { Id = id, AudienceId = audienceId, TeacherId = teacherId, DisciplineId = disciplineId, GroupId = groupId, LessonDate = DateTime.Now, LessonTime = lessonTime, LessonType = lessonType };
    }
}