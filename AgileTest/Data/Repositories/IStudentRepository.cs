using AgileTest.Data.Entities;
using System.Collections.Generic;

namespace AgileTest.Data.Repositories
{
    public interface IStudentRepository
    {
        List<StudentEntity> GetAll();

        StudentEntity Get(int id);

        StudentEntity Get(string dni);

        StudentEntity Create(StudentEntity entity);

        StudentEntity Update(StudentEntity entity);
    }
}
