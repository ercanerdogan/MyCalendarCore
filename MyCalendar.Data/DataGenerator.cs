using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCalendar.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MyCalendar.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            CultureInfo cultures = new CultureInfo("en-US");

            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Look for any appointments
                if (context.Appointments.Any())
                {
                    return;   // Data was already seeded
                }

                context.Appointments.AddRange(
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

                    },

                    new Appointment
                    {
                        Id = 4,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("02/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"

                    },

                    new Appointment
                    {
                        Id = 5,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("02/02/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 6,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("02/03/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 7,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("03/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 8,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("03/02/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 9,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("04/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 10,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("04/02/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 11,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("04/03/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 12,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("04/04/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 13,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("04/05/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 14,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("05/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 15,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("05/02/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 16,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("06/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 17,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("07/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 18,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("08/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 19,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("09/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 20,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("10/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    },

                    new Appointment
                    {
                        Id = 21,
                        Organizer = "Ercan",
                        Description = "Daily Meeting",
                        Subject = "Sprint Daily",
                        AppointmentDate = Convert.ToDateTime("11/01/2021 10:00am", cultures),
                        Attendees = "Ercan, John, Jane"
                    }
                    //},

                    //new Appointment
                    //{
                    //    Id = 22,
                    //    Organizer = "Ercan",
                    //    Description = "Daily Meeting",
                    //    Subject = "Sprint Daily",
                    //    AppointmentDate = Convert.ToDateTime("12/01/2021 10:00am", cultures),
                    //    Attendees = "Ercan, John, Jane"
                    //}

                );

                context.SaveChanges();
            }
        }
    }
}
