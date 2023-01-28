using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zad8.Entities.Configurations;
using Zad8.Services;

namespace Zad8.Entities
{
    public class PrescriptionContext : DbContext, IPrescriptionContext
    {
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public PrescriptionContext(DbContextOptions<PrescriptionContext> options) : base(options)
        {

        }

        public PrescriptionContext() { }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(typeof(DoctorEfConfiguration).GetTypeInfo().Assembly);
            model.Seed();
        }
    }
}
