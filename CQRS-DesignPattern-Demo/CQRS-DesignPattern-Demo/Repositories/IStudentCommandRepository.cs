using CQRS_DesignPattern_Demo.Models.Entities;

namespace CQRS_DesignPattern_Demo.Repositories
{
    public interface IStudentCommandRepository
    {
        Student SaveStudent(Student student);
    }
}
