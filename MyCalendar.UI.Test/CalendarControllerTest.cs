using Microsoft.AspNetCore.Mvc;
using Moq;
using MyCalendar.Business.Repositories;
using MyCalendar.Controllers;
using MyCalendar.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyCalendar.UI.Test
{
    public class CalendarControllerTest
    {
        private readonly Mock<IAppointmentRepository> _mockRepo;
        private readonly CalendarController _controller;
        private List<Appointment> appointments;

        public CalendarControllerTest()
        {
            _mockRepo = new Mock<IAppointmentRepository>();
            _controller = new CalendarController(_mockRepo.Object);
            CultureInfo cultures = new CultureInfo("en-US");

            appointments = new List<Appointment>()
            {
                new Appointment
                    {
                        Id = 1,
                        Organizer = "Ercan",
                        Description = "Team Meeting",
                        Subject = "New Project",
                        AppointmentDate = Convert.ToDateTime("01/01/2021 9:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },
                    new Appointment
                    {
                        Id = 2,
                        Organizer = "Ercan",
                        Description = "Project Meeting",
                        Subject = "Deployment to the Customer",
                        AppointmentDate = Convert.ToDateTime("01/02/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"

                    },
                    new Appointment
                    {
                        Id = 3,
                        Organizer = "Ercan",
                        Description = "Job Applicants",
                        Subject = "New Candidates Assesment",
                        AppointmentDate = Convert.ToDateTime("01/03/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"

                    }
            };

        }

        [Theory]
        [InlineData(1)]
        public void Index_ActionExecutes_ReturnView(int? id)
        {
            var result = _controller.Index(id);

            Assert.IsType<ViewResult>(result);

        }

        [Theory]
        [InlineData(5)]
        public void GetAppointments_ByMonth_ReturnNotFound(int monthId)
        {
            List<Appointment> appList = new List<Appointment>();
            _mockRepo.Setup(repo => repo.Find(ap => ap.AppointmentDate.Month == monthId)).Returns(appList);

            var result = _controller.GetAppointments(monthId);

            var redirect = Assert.IsType<NotFoundResult>(result);

            Assert.Equal<int>(404, redirect.StatusCode);

        }

        [Theory]
        [InlineData(1)]
        public void GetAppointments_ActionExecutes_ReturnAppointmentList(int monthId)
        {
            _mockRepo.Setup(repo => repo.Find(ap => ap.AppointmentDate.Month == monthId)).Returns(appointments);

            var result = _controller.GetAppointments(monthId);

            var viewResult = Assert.IsType<PartialViewResult>(result);

            var appointmentList = Assert.IsAssignableFrom<IEnumerable<Appointment>>(viewResult.Model);

            Assert.Equal(3, appointmentList.Count());

        }

        [Theory]
        [InlineData(1)]
        public void GetAppointmentDetails_IdInvalid_ReturnNotFound(int appId)
        {
            Appointment appointment = null;
            _mockRepo.Setup(repo => repo.GetById(appId)).Returns(appointment);

            var result = _controller.GetAppointmentDetails(appId);

            var redirect = Assert.IsType<NotFoundResult>(result);

            Assert.Equal<int>(404, redirect.StatusCode);

        }



        [Theory]
        [InlineData(1)]
        public void GetAppointmentDetails_IdInvalid_ReturnAppointmentDetails(int id)
        {
            Appointment appointment = appointments.First(x => x.Id == id);
            _mockRepo.Setup(repo => repo.GetById(id)).Returns(appointment);

            var result = _controller.GetAppointmentDetails(id);

            var viewResult = Assert.IsType<PartialViewResult>(result);

            var resultAppointment = Assert.IsAssignableFrom<Appointment>(viewResult.Model);

            Assert.Equal(appointment.Id, resultAppointment.Id);

        }


        

    }
}
