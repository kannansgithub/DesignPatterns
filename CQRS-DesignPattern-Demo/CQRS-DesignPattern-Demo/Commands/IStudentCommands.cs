using CQRS_DesignPattern_Demo.Models.DTOs;
using CQRS_DesignPattern_Demo.Models.Entities;

namespace CQRS_DesignPattern_Demo.Commands
{
    public interface IStudentCommands
    {
        StudentDTO SaveStudent(Student student);

    }
}
