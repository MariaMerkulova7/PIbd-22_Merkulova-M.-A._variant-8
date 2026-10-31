using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Repositories.Implementations
{
    internal class StudentGroupRepository : IStudentGroupRepository
    {
        public void CreateStudentGroup(StudentGroup studentGroup) { }
        public void DeleteStudentGroup(int id) { }
        public StudentGroup ReadStudentGroupById(int id) => StudentGroup.CreateEntity(0, string.Empty, 0, 0);
        public IEnumerable<StudentGroup> ReadStudentGroups() => [];
        public void UpdateStudentGroup(StudentGroup studentGroup) { }
    }
}