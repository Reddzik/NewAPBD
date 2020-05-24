using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Models
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public PeopleDbContext() { }
        public PeopleDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
