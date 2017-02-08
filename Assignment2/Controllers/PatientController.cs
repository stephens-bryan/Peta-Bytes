using System;
using System.Collections.Generic; // allows for List object to be called within Assignment.Controllers namespace
using System.Linq; // namespace provides classes and interfaces that support queries that use Language-Integrated Query (LINQ)
using System.Web;
using System.Web.Mvc; // namespace that allows for calling of Controller methods (i.e. ActionResult)
using Assignment2.Models; // calls on objects defined within Models folder

namespace Assignment2.Controllers
{
    public class PatientController : Controller
    {
        // Constructs a new context instance using conventions to create the name of the db to which a connection will be made
        // Name is the full name (namespace + class name) of the derived context class
        PatientContext patientContext = new PatientContext();
        // GET: Patient
        public ActionResult Index()
        {
            //List of all patients in db
            // ToList() ==> creates a list from IEnumerable
            List<Patient> patient = patientContext.Patients.ToList();
            return View(patient);
        }
    }
}