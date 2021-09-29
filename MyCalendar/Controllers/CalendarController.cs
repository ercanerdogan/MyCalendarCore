using Microsoft.AspNetCore.Mvc;
using MyCalendar.Business;
using MyCalendar.Business.Repositories;
using MyCalendar.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalendar.Controllers
{
    public class CalendarController : Controller
    {
        private readonly IAppointmentRepository _repository;

        public CalendarController(IAppointmentRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Index(int? id)
        {
            var monthId = id ?? 1;
            var appList = _repository.Find(ap => ap.AppointmentDate.Month == monthId);

            return View(appList);
            //return View();
        }

        
        public IActionResult GetAppointments(int id)
        {
            var appList = _repository.Find(ap=>ap.AppointmentDate.Month == id);

            return PartialView("AppointmentList", appList);
        }

        public IActionResult GetAppointmentDetails(int id)
        {
            var appointment = _repository.GetById(id);

            return PartialView("AppointmentDetail", appointment);
        }

        public IActionResult DeleteAppointment(int id)
        {
            var entity = _repository.GetById(id);
            if (entity!=null)
            {
                _repository.Delete(entity);
            }

            return RedirectToAction("Index");
        }

    }
}
