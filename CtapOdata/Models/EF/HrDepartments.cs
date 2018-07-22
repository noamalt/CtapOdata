using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrDepartments
    {
        public HrDepartments()
        {
            HrDepartmentTypesMapping = new HashSet<HrDepartmentTypesMapping>();
            HrUsers = new HashSet<HrUsers>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int? DepartmentManagerId { get; set; }

        public ICollection<HrDepartmentTypesMapping> HrDepartmentTypesMapping { get; set; }
        public ICollection<HrUsers> HrUsers { get; set; }
    }
}
