using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalendar.Core.Models
{
    public class Appointment : BaseClass
    {
        public string Subject { get; set; }
        public string Organizer { get; set; }
       
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }

        public string Attendees { get; set; }

        //public ICollection<Employee> Attendees { get; set; }

    }

}
