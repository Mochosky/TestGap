using Appointments.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appointments.Services.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppointmentService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        Task<List<AppointmentDto>> GetByPatientId(int patientId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<AppointmentDto> GetByPatientDate(int patientId, DateTime date);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<AppointmentDto> Assign(int patientId, DateTime date);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        Task UnAssign(Guid appointmentId);
    }
}
