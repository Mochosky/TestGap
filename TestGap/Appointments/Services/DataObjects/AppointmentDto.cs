using System;

namespace Appointments.Services.DataObjects
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public Guid AppointmentTypeId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
