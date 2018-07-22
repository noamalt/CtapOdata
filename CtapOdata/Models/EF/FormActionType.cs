using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class FormActionType
    {
        public FormActionType()
        {
            LandingPageInstances = new HashSet<LandingPageInstances>();
        }

        public int FormActionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<LandingPageInstances> LandingPageInstances { get; set; }
    }
}
