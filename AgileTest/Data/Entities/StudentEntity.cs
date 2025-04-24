using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileTest.Data.Entities
{
    public class StudentEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

    }
}
