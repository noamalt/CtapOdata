using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class AccountTokenTypes
    {
        public AccountTokenTypes()
        {
            AccountTokens = new HashSet<AccountTokens>();
        }

        public int AccountTokenTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<AccountTokens> AccountTokens { get; set; }
    }
}
