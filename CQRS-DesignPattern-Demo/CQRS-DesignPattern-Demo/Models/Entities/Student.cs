using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_DesignPattern_Demo.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
