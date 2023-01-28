﻿using Zad8.Entities;
using System;
using System.Collections.Generic;

namespace Zad8.DTO
{
    public class PrescriptionDTO
    {
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public PatientDTO Patient { get; set; }
        public DoctorDTO Doctor { get; set; }
        public IList<MedicamentDTO> Medicaments { get; set; }
    }
}
