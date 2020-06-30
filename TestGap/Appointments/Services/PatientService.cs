using Appointments.Exceptions;
using Appointments.Models;
using Appointments.Repositories.Interfaces;
using Appointments.Services.DataObjects;
using Appointments.Services.Interfaces;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Appointments.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        }

        public async Task<PatientDto> CreatePatientAsync(PatientDto patientDto)
        {
            var storedPatient = await _patientRepository.GetByDocumentAsync(patientDto.DocumentType, patientDto.Document);
            if (storedPatient != null)
                throw new AppointmentException("The patient is already registered.", ErrorCodes.PatientRegistered);

            var patientEntity = _mapper.Map<Patient>(patientDto);
            patientEntity.Created = DateTime.Now;
            await _patientRepository.CreatePatientAsync(patientEntity);

            var savedPatient = await _patientRepository.GetByDocumentAsync(patientDto.DocumentType, patientDto.Document);
            return _mapper.Map<PatientDto>(savedPatient);
        }

        public async Task<PatientDto> GetByIdAsync(int patientId)
        {
            var patientEntity = await _patientRepository.GetByIdAsync(patientId);
            return _mapper.Map<PatientDto>(patientEntity);
        }
    }
}
