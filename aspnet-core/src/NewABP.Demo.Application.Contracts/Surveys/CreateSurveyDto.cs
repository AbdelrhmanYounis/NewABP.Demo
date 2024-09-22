using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Surveys
{
    public class CreateSurveyDto:EntityDto<int>
    {
        public string ProblemsAndSuggestions { get; set; }
        public DateTime Date { get; set; }
        public int ParkId { get; set; }
        public int BandId { get; set; }
        public int GradeId { get; set; }
    }
}
