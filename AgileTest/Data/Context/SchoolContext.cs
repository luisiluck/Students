using AgileTest.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AgileTest.Data.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SchoolDB");
            base.OnConfiguring(optionsBuilder);
        }

        public void Seed()
        {
            if (Students.Count() == 0)
            {
                Students.Add(new StudentEntity { Id = 1, DNI = "1523456A", Name ="Juan", Surname = "Sanchez", Birthday = new DateTime(1988, 12, 25), Phone="655127856", Active  = true });
                Students.Add(new StudentEntity { Id = 2, DNI = "123456B", Name ="Luis", Surname = "Casanova", Birthday = new DateTime(1988, 08, 12), Phone="5998416", Active  = false });
                Students.Add(new StudentEntity { Id = 3, DNI = "1623456C", Name ="Carmen", Surname = "Lopez", Birthday = new DateTime(1988, 06, 18), Phone="559910643", Active  = true });
                Students.Add(new StudentEntity { Id = 4, DNI = "1236456D", Name ="Jose", Surname = "Perez", Birthday = new DateTime(1988, 06, 18), Phone="5558747898", Active  = true });
                SaveChanges();
            }
        }
    }
}
