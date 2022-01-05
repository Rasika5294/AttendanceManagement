using System;
using System.Collections.Generic;

#nullable disable

namespace Attendance_Management_System.Models
{
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPassword { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerPhone { get; set; }
    }
}
