using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrDepartmentTypesMapping
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int DepartmentTypeId { get; set; }

        public HrDepartments Department { get; set; }
        public HrDepartmentTypes DepartmentType { get; set; }
    }
}
