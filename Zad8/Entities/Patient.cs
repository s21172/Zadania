using System;
using System.Collections.Generic;
using Zad8.Entities;

public class Patient
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    
    public virtual ICollection<Prescription> Prescriptions { get; set; }

    public Patient()
    {
        Prescriptions = new HashSet<Prescription>();
    }
}