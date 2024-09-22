using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Common.Grades
{
    public class GradeDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
