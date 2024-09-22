using NewABP.Demo.Common.Cities;
using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Common.Areas
{
    public class Area : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
