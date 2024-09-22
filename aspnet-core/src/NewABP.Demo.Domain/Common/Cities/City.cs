using NewABP.Demo.Common.Governorates;
using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Common.Cities
{
    public class City : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int GovernorateId { get; set; }
        public virtual Governorate Governorate { get; set; }
    }
}
