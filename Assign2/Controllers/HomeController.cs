using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assign2.Models;

namespace Assign2.Controllers
{
    public class HomeController : Controller
    {
        PatientContext patientContext = new PatientContext();
        // GET: Home
        public ActionResult Index()
        {
            List<Patient> patients = patientContext.Patients.ToList();
            return View(patients);
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Patient patient = patientContext.Patients.Single(p => p.Id == id);
                return View(patient);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}