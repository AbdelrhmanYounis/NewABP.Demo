using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Common.Governorates
{
    public class GovernorateDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
