using System;

namespace AgileTest.Common.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Active { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

    }
}
