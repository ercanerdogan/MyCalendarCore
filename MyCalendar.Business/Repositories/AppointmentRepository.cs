using MyCalendar.Core.Models;
using MyCalendar.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalendar.Business.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
