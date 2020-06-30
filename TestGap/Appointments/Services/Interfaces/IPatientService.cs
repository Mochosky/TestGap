using Appointments.Services.DataObjects;
using System.Threading.Tasks;

namespace Appointments.Services.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPatientService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        Task<PatientDto> GetByIdAsync(int patientId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientDto"></param>
        /// <returns></returns>
        Task<PatientDto> CreatePatientAsync(PatientDto patientDto);
    }
}
