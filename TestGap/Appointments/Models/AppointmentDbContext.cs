using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Appointments.Models
{
    public class AppointmentDbContext : IdentityDbContext<User>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public AppointmentDbContext() { }

        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.DataSeed();
        }
    }
}
