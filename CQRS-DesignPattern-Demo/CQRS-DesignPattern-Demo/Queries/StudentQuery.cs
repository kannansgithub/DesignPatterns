using CQRS_DesignPattern_Demo.Models.DTOs;
using CQRS_DesignPattern_Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_DesignPattern_Demo.Queries
{
    public class StudentQuery : IStudentQuery
    {
        private readonly IStudentQueryRepository _repository;

        public StudentQuery(IStudentQueryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public StudentDTO FindByID(Guid studentID)
        {
            var stud = _repository.GetByID(studentID);
            return new StudentDTO
            {
                Id = stud.Id,
                FullName = $"{stud.FirstName} {stud.LastName}",
                Address = stud.Address,
            };
        }
    }
}
