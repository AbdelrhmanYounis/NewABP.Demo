using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Common.Governorates
{
    public class Governorate : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
