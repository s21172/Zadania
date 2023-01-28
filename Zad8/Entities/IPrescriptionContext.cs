﻿using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Zad8.Entities
{
    public interface IPrescriptionContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
