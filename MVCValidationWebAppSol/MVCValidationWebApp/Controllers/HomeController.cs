using MVCValidationWebApp.Models.Abstract;
using MVCValidationWebApp.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebAppMvcValidation.Controllers
{

    //validation at controller action method
    public class HomeController : Controller
    {
        IAppointment repo;
        public HomeController(IAppointment repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            ViewBag.Appointments = repo.GetAll();
            Appointment appointment=new Appointment() { Appointment_Date=DateTime.Now };
            return View(appointment);
        }
        [HttpPost]
        public ActionResult Index(Appointment appt)
        {
            ViewBag.Appointments = repo.GetAll();
            if (string.IsNullOrEmpty(appt.DoctorName))
            {
                ModelState.AddModelError("DoctorName", "Please Enter the Doctor Name");
            }
            if(appt.Appointment_Date<DateTime.Now)
            {
                ModelState.AddModelError("Appointment_Date", "Please select future date");
            }
            if(!appt.TermAccepted)
            {
                ModelState.AddModelError("TermAccepted", "Accept the Terms");
            }
            if (ModelState.IsValidField("DoctorName") &&
                ModelState.IsValidField("Appointment_Date")
                && ModelState.IsValidField("TermAccepted") &&
                appt.DoctorName == "C" &&
                appt.Appointment_Date.DayOfWeek == DayOfWeek.Monday
                )
            {
                ModelState.AddModelError("", "C Cannot be booked on monday");
            }
            if (ModelState.IsValid)
            {
                repo.Save(appt);
            }
            else
            {
                return View();
            }
            return RedirectToAction("Index");
        }
       
    }
}