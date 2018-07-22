using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class FinancialAccountTypesAssignments
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int FinancialAccountTypeId { get; set; }
        public bool? IsModified { get; set; }
        public DateTime? DateModified { get; set; }

        public Accounts Account { get; set; }
        public FinancialAccountTypes FinancialAccountType { get; set; }
    }
}
