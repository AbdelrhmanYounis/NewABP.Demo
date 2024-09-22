using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Parks
{
    public class ParkDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int AreaId { get; set; }

    }
}
