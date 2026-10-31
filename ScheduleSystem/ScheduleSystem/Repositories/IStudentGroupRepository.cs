using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleSystem.Entities;

namespace ScheduleSystem.Repositories
{
    public interface IStudentGroupRepository
    {
        IEnumerable<StudentGroup> ReadStudentGroups();
        StudentGroup ReadStudentGroupById(int id);
        void CreateStudentGroup(StudentGroup studentGroup);
        void UpdateStudentGroup(StudentGroup studentGroup);
        void DeleteStudentGroup(int id);
    }
}
