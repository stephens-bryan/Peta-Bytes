using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // namespace contains classes that provides access to the core functionality of the entity framework

namespace Assignment2.Models
{
    public class PatientContext : DbContext // initialize new instance of DbContext class;
    {
        //Access patients from db through Patient.cs
        //needs to be set to public (accessing outside of class)
        // represents the collection of all entities in the Patientcontext, or that can be queried from the db, of a given type
        public DbSet<Patient> Patients { get; set; }
    }
}