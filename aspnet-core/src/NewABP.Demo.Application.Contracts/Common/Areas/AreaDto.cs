using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Common.Areas
{
    public class AreaDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CityId { get; set; }

    }
}
