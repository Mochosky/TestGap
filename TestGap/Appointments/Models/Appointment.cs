using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointments.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int AppointmentTypeId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
