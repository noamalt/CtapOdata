using System;
using System.Collections.Generic;

namespace CtapOdata.Models.EF
{
    public partial class RegulationQuestionnaireAnswers
    {
        public int AnswerId { get; set; }
        public string AnswerString { get; set; }
        public string Key { get; set; }
        public int LanguageId { get; set; }
    }
}
