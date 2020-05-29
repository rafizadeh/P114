using _22052020.DAL;
using _22052020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22052020.Controllers
{
    public class DoctorController : Controller
    {
        private readonly HospitalContext _db = new HospitalContext();


        public ActionResult Index()
        {

            List<Doctor> doctors = _db.Doctors.Include("Department").ToList();

            return View(doctors);
        }

        public ActionResult Detail(int id)
        {
            var doctor = _db.Doctors.Include("Department").FirstOrDefault(d => d.Id == id);

            if(doctor == null)
            {
                return HttpNotFound();
            }

            return View(doctor);
        }
    }
}