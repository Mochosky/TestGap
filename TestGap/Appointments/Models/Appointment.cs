using System;
using System.ComponentModel.DataAnnotations;

namespace Appointments.Models
{
    public class Appointment : BaseEntity
    {
        [Key]
        public int AppointmentId { get; set; }
        public Guid AppointmentTypeId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
