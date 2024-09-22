using Volo.Abp.Domain.Entities;

namespace NewABP.Demo.Common.Grades
{
    public class Grade : Entity<int>
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
