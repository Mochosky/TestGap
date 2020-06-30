using Appointments.Models;
using Appointments.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointments.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Task<Appointment> CreateAppointment(int patientId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> GetByPatientDate(int patientId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<Appointment>> GetByPatientId(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
