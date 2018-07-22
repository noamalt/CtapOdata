using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class EmailPromotionActions
    {
        public int EmailPromotionActionId { get; set; }
        public string EmailPromotionActionName { get; set; }

        public EmailPromotionActions EmailPromotionAction { get; set; }
        public EmailPromotionActions InverseEmailPromotionAction { get; set; }
    }
}
