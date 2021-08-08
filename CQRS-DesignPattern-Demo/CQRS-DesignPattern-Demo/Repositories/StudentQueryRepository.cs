using CQRS_DesignPattern_Demo.Models.Entities;
using System;
using System.Linq;

namespace CQRS_DesignPattern_Demo.Repositories
{
    public class StudentQueryRepository : IStudentQueryRepository
    {
        public Student GetByID(Guid studentID)
        {
            using var context = new StudentContext(StudentContext.option);
            return context.Students.FirstOrDefault(x => x.Id == studentID);
        }
    }
}
