using AgileTest.Data.Context;
using AgileTest.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AgileTest.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext Context;

        public StudentRepository(SchoolContext context)
        {
            Context = context;
        }

        public List<StudentEntity> GetAll()
        {
            return Context.Students.OrderBy(s=> s.DNI).ToList();
        }

        public StudentEntity Get(int id)
        {
            return Context.Students.FirstOrDefault(e=> e.Id == id);
        }

        public StudentEntity Get(string dni)
        {
            return Context.Students.FirstOrDefault(e => e.DNI == dni);
        }

        public StudentEntity Create(StudentEntity entity)
        {
            Context.Students.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public StudentEntity Update(StudentEntity entity)
        {
            Context.Students.Update(entity);
            Context.SaveChanges();
            return entity;
        }
    }
}
