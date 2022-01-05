using System;
using System.Collections.Generic;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class PublicHoliday
    {
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public string Details { get; set; }
    }
}
