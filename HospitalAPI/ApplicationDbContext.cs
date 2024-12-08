using HospitalAPI.Models;
using System.Collections.Generic;

namespace HospitalAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
