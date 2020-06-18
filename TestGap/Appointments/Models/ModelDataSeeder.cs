using Microsoft.EntityFrameworkCore;
using System;

namespace Appointments.Models
{
    public static class ModelDataSeeder
    {
        public static void DataSeed(this ModelBuilder builder)
        {
            builder.Entity<AppointmentType>()
                .HasData(
                new { AppointmentTypeId = Guid.Parse("50e2d2ca-f4d1-4596-8c1f-0ccc78906f31"), Name = "Medicina General" },
                new { AppointmentTypeId = Guid.Parse("009e47d0-38c2-489c-bfd4-7f9a855a699f"), Name = "Odontología" },
                new { AppointmentTypeId = Guid.Parse("a79365da-9a02-4e86-bdc6-111b09bc1eae"), Name = "Pediatría" },
                new { AppointmentTypeId = Guid.Parse("27e552c6-70f7-4f2f-926d-d790c6ca47ef"), Name = "Neurología" });
        }
    }
}
