using CQRS_DesignPattern_Demo.Models.DTOs;
using CQRS_DesignPattern_Demo.Models.Entities;
using CQRS_DesignPattern_Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_DesignPattern_Demo.Commands
{
    public class StudentCommands : IStudentCommands
    {
        private readonly IStudentCommandRepository _repository;

        public StudentCommands(IStudentCommandRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public StudentDTO SaveStudent(Student student)
        {
           var stud= _repository.SaveStudent(student);
            return new StudentDTO
            {
                Id = stud.Id,
                FullName = $"{stud.FirstName} {stud.LastName}",
                Address = stud.Address,
            };
        }
    }
}
