using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Common.Cities
{
    public class CityDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int GovernorateId { get; set; }
    }
}
