using System; // namespace that allows for DateTime to be used
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // namespace that allows for Table attribute to be used
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    //Table() ==> specify what tbl in db that Patient.cs is mapped to
    [Table("Patient")]
    public class Patient
    {
        // ***do need to set an Id property. My apologizes on that***
        // naming convention ==> must match column names in Patient tbl
        public int Id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string healthNum { get; set; }
        public DateTime birthDate { get; set; }
    }
}