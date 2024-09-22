using Volo.Abp.Application.Dtos;

namespace NewABP.Demo.Bands
{
    public class BandDto : EntityDto<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
