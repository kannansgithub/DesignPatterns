using CQRS_DesignPattern_Demo.Models.DTOs;
using System;

namespace CQRS_DesignPattern_Demo.Queries
{
    public interface IStudentQuery
    {
        StudentDTO FindByID(Guid studentID);
    }
}
