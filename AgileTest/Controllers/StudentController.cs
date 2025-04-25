using System;
using AgileTest.Common.Models;
using AgileTest.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgileTest.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBL StudentBL;

        public StudentController(IStudentBL studentBL)
        {
            StudentBL = studentBL;  
        }

        [HttpGet]
        public List<StudentModel> GetAll()
        {
            var result = StudentBL.GetAll();

            return result;
        }

        [HttpGet("{id}")]
        public StudentModel Get(int id)
        {
            var result = StudentBL.Get(id);

            return result;
        }

        [HttpPut("{id}/activate")]
        public StudentModel Activate(int id)
        {
            var result = StudentBL.Activate(id);

            return result;
        }

        [HttpPut("{id}/disable")]
        public StudentModel Disable(int id)
        {
            var result = StudentBL.Disable(id);

            return result;
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        [HttpPost]
        public IActionResult Create(StudentCreateModel model)
        {
            try
            {
                return Ok(StudentBL.Create(model));
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
