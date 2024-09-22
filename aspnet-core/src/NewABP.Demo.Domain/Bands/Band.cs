using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Bands
{
    public class Band : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
