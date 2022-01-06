using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class Employee
    {
        [Key]
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
       // public Task<ActionResult<Employee>> Entity { get; internal set; }
       
    }
}
