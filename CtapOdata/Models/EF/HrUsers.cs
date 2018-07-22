using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrUsers
    {
        public int HruserId { get; set; }
        public int? DepartmentId { get; set; }
        public int? LocationId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public int? TeamLeaderId { get; set; }
        public int WorkerNumber { get; set; }
        public string Phone { get; set; }
        public string Ext { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }

        public HrDepartments Department { get; set; }
    }
}
