using Volo.Abp.Domain.Entities;
using NewABP.Demo.Common.Areas;
namespace NewABP.Demo.Parks
{
    public class Park : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }        
    }
}
