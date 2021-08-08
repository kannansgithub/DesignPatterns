using CQRS_DesignPattern_Demo.Models.Entities;
using System;

namespace CQRS_DesignPattern_Demo.Repositories
{
    public interface IStudentQueryRepository
    {
        Student GetByID(Guid studentID);
    }
}
