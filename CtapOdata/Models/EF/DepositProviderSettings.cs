using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class DepositProviderSettings
    {
        public int ProviderSettingId { get; set; }
        public string SettingName { get; set; }
        public int DepositProviderId { get; set; }
        public int CurrencyId { get; set; }
        public string MerchantId { get; set; }
        public string BrandId { get; set; }
        public string StoreId { get; set; }
        public string ExtSecret { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public int? OfficeId { get; set; }
        public int? PaymentMethodId { get; set; }

        public Currencies Currency { get; set; }
        public DepositProviders DepositProvider { get; set; }
        public Offices Office { get; set; }
    }
}
