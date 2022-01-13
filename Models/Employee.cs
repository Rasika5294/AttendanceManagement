using System;
using System.Collections.Generic;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Leaves = new HashSet<Leave>();
        }

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpPassword { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public double TotalLeaves { get; set; }
        public double? LeavesTaken { get; set; }

        public virtual Attendance Attendance { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
