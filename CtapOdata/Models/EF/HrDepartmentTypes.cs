using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class HrDepartmentTypes
    {
        public HrDepartmentTypes()
        {
            HrDepartmentTypesMapping = new HashSet<HrDepartmentTypesMapping>();
        }

        public int DepartmentTypeId { get; set; }
        public string DepartmentTypeName { get; set; }

        public ICollection<HrDepartmentTypesMapping> HrDepartmentTypesMapping { get; set; }
    }
}
