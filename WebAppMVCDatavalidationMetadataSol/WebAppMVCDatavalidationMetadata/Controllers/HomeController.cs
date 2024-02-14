
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCDatavalidationMetadata.Models.Abstract;
using WebAppMVCDatavalidationMetadata.Models.Concrete;

namespace WebAppMVCDatavalidationMetadata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        
            IAppointment appointment;
            public HomeController(IAppointment appointment)
            {
                this.appointment = appointment;
            }

            public ActionResult Index()
            {
                ViewBag.Appointments = appointment.GetAll();
                Appointment app = new Appointment() { Appointment_Date = DateTime.Now };
                return View(app);
            }

            [HttpPost]
            public ActionResult Index(Appointment app)
            {
                ViewBag.Appointments = appointment.GetAll();
                if (ModelState.IsValid)
                {
                    appointment.Save(app);
                }
                else
                {
                    return View();
                }
                return RedirectToAction("Index");
            }
        }
    }
