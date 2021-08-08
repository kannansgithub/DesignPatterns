using CQRS_DesignPattern_Demo.Commands;
using CQRS_DesignPattern_Demo.Models.Entities;
using CQRS_DesignPattern_Demo.Queries;
using CQRS_DesignPattern_Demo.Repositories;
using System;

namespace CQRS_DesignPattern_Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var studCommand = new StudentCommands(new StudentCommandRepository());
            var stud=studCommand.SaveStudent(new Student
            {
                FirstName = "Kannan",
                LastName = "S",
                Address ="My local address"
            });
            Console.WriteLine($"Student Created InMemory with Id {stud.Id}");
            // Query the Employee Domain to get data  
            var studentQuery = new StudentQuery(new StudentQueryRepository());
            var readStud = studentQuery.FindByID(stud.Id);
            Console.WriteLine($"Student ID:{readStud.Id}, Name:{readStud.FullName}, Address:{readStud.Address}");
            Console.ReadKey();
        }
    }
}
