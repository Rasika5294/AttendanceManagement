using System;
using System.Collections.Generic;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class Leave
    {
        public int? EmpId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ReasonForLeave { get; set; }
        public string TypeOfLeave { get; set; }
        public DateTime? TimeIfAny { get; set; }
        public string Status { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
