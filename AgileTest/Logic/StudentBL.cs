using AgileTest.Common.Models;
using AgileTest.Data.Entities;
using AgileTest.Data.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgileTest.Logic
{
    public class StudentBL : IStudentBL
    {
        private readonly IStudentRepository StudentRepository;

        public StudentBL(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public StudentModel Activate(int id)
        {
            var entity = StudentRepository.Get(id);

            entity.Active = true;

            StudentRepository.Update(entity);

            return Mapper.Map<StudentModel>(entity);
        }

        public StudentModel Create(StudentCreateModel model)
        {
            if(model == null)
            {
                throw new ValidationException("Student data not provided"); 
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ValidationException("Student Name not provided");
            }
            if (string.IsNullOrEmpty(model.Surname))
            {
                throw new ValidationException("Student Surname not provided");
            }
            if (string.IsNullOrEmpty(model.Phone))
            {
                throw new ValidationException("Student Phone not provided");
            }
            if (model.Birthday == DateTime.MinValue)
            {
                throw new ValidationException("Student Birthday not provided");
            }
            if (string.IsNullOrEmpty(model.DNI))
            {
                throw new ValidationException("Student DNI not provided");
            }
            var existingUser = StudentRepository.Get(model.DNI);
            if (existingUser != null)
            {
                throw new ValidationException("Student already registered");
            }

            var entity = new StudentEntity();
            entity.DNI = model.DNI;
            entity.Name = model.Name;
            entity.Surname = model.Surname;
            entity.Active = false;
            entity.Birthday = model.Birthday;
            entity.Phone = model.Phone;

            entity = StudentRepository.Create(entity);

            return Mapper.Map<StudentModel>(entity);
        }

        public StudentModel Disable(int id)
        {
            var entity = StudentRepository.Get(id);

            entity.Active = false;

            StudentRepository.Update(entity);

            return Mapper.Map<StudentModel>(entity);
        }

        public StudentModel Get(int id)
        {
            var entity = StudentRepository.Get(id);

            return Mapper.Map<StudentModel>(entity);
        }

        public List<StudentModel> GetAll()
        {
            var entities = StudentRepository.GetAll();

            return Mapper.Map<List<StudentModel>>(entities);
        }
    }
}
