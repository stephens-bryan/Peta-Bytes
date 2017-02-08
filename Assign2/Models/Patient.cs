using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assign2.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Table")]
    public class Patient
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Health Card #")]
        public string healthCarNum { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0: MMMM dd, yyyy}")]
        public DateTime birthDate { get; set; }

        // concat firstName & lastName together
        public string fullName()
        {
            return this.firstName + " " + this.lastName;
        }
        
    }

    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}