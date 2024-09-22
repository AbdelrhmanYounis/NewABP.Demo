using NewABP.Demo.Parks;
using NewABP.Demo.SurveyBands;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Surveys
{
    public class Survey :Entity<int>
    {
        public string ProblemsAndSuggestions { get; set; }
        public DateTime Date { get; set; }
        public int ParkId { get; set; }
        public virtual Park Park { get; set; }
    }
}
