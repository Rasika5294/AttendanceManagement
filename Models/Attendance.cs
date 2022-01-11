using System;
using System.Collections.Generic;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class Attendance
    {
        public int EmpId { get; set; }
        public DateTime Dates { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public decimal TotalInTime { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
