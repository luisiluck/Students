using AgileTest.Common.Models;
using System.Collections.Generic;

namespace AgileTest.Logic
{
    public interface IStudentBL
    {
        List<StudentModel> GetAll();    
        
        StudentModel Get(int id);    
        
        StudentModel Activate(int id);

        StudentModel Disable(int id);

        StudentModel Create(StudentCreateModel model);
    }
}
