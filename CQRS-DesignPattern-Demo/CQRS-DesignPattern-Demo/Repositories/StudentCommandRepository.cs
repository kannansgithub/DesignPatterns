using CQRS_DesignPattern_Demo.Models.Entities;

namespace CQRS_DesignPattern_Demo.Repositories
{
    public class StudentCommandRepository : IStudentCommandRepository
    {
        public Student SaveStudent(Student student)
        {
            using var context = new StudentContext(StudentContext.option);
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }
    }
}
