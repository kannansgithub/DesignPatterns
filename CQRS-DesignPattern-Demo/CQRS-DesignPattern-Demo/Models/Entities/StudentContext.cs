using Microsoft.EntityFrameworkCore;

namespace CQRS_DesignPattern_Demo.Models.Entities
{
    public class StudentContext: DbContext
    {
        public static DbContextOptions<StudentContext> option = new DbContextOptionsBuilder<StudentContext>()
   .UseInMemoryDatabase(databaseName: "TestDB")
   .Options;
        public StudentContext(DbContextOptions<StudentContext> options)
       : base(options)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
