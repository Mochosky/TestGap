using Appointments.Models;
using Appointments.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Appointments.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppointmentDbContext _dbContext;

        public PatientRepository(AppointmentDbContext dbContext) => _dbContext = dbContext ??
            throw new ArgumentNullException(nameof(dbContext));

        public async Task<int> CreatePatientAsync(Patient patientEntity)
        {
            _dbContext.Patients.Add(patientEntity);
            await _dbContext.SaveChangesAsync();

            return patientEntity.PatientId;
        }

        public Task<Patient> GetByDocumentAsync(DocType typeDoc, string doc)
        {
            return _dbContext.Patients.FirstOrDefaultAsync(p => p.DocumentType == typeDoc && p.Document == doc);
        }

        public Task<Patient> GetByIdAsync(int patientId)
        {
            return _dbContext.Patients.FirstOrDefaultAsync(p => p.PatientId == patientId);
        }
    }
}
