using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class FinancialAccountTypes
    {
        public FinancialAccountTypes()
        {
            FinancialAccountTypesAssignments = new HashSet<FinancialAccountTypesAssignments>();
        }

        public int Id { get; set; }
        public string FinancialAccountTypeName { get; set; }
        public string FinancialAccountTypeDescription { get; set; }

        public ICollection<FinancialAccountTypesAssignments> FinancialAccountTypesAssignments { get; set; }
    }
}
