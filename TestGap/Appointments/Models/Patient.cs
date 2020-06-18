using System;
using System.ComponentModel.DataAnnotations;

namespace Appointments.Models
{
    public class Patient : BaseEntity
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DocType DocumentType { get; set; }
        public string Document { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
