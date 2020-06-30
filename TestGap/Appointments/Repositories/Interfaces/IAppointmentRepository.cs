using Appointments.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appointments.Repositories.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppointmentRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        Task<List<Appointment>> GetByPatientId(int patientId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<Appointment> GetByPatientDate(int patientId, DateTime date);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<Appointment> CreateAppointment(int patientId, DateTime date);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        Task DeleteAppointment(Appointment appointment);
    }
}
