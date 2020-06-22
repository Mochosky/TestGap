using Appointments.Models;
using System;

namespace Appointments.Services.DataObjects
{
    public class PatientDto
    {
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
