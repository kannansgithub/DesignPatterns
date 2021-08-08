using System;

namespace CQRS_DesignPattern_Demo.Models.DTOs
{
    public class StudentDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
