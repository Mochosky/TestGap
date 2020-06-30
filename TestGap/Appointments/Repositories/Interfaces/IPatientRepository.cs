using Appointments.Models;
using System.Threading.Tasks;

namespace Appointments.Repositories.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPatientRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientEntity"></param>
        /// <returns></returns>
        Task<int> CreatePatientAsync(Patient patientEntity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        Task<Patient> GetByIdAsync(int patientId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeDoc"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        Task<Patient> GetByDocumentAsync(DocType typeDoc, string doc);
    }
}
