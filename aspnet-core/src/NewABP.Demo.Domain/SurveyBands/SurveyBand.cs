using NewABP.Demo.Bands;
using NewABP.Demo.Common.Grades;
using NewABP.Demo.Surveys;
using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.SurveyBands
{
    public class SurveyBand : Entity<int>
    {
        public int SurveyId { get; set; }
        public int BandId { get; set; }
        public int GradeId { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual Band Band { get; set; }
        public virtual Grade Grade { get; set; }

    }
}
