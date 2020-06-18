using System;
using System.ComponentModel.DataAnnotations;

namespace Appointments.Models
{
    public class AppointmentType
    {
        [Key]
        public Guid AppointmentTypeId { get; set; }
        public string Name { get; set; }
    }
}
