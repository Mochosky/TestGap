using Appointments.Models;
using Appointments.Services.DataObjects;
using AutoMapper;

namespace Appointments.Services.Mappings
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<AppointmentType, AppointmentTypeDto>().ReverseMap();
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
        }
    }
}
