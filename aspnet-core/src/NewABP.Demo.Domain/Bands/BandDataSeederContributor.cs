using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Bands
{
    public class BandDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Band, int> _bandRepository;

        public BandDataSeederContributor(IRepository<Band, int> bandRepository)
        {
            _bandRepository = bandRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bandRepository.GetCountAsync() < 1)
            {
                await _bandRepository.InsertManyAsync(
                      new List<Band>()
                      {
                        new Band() {
                            NameEn="Service area",
                            NameAr="منطقة الخدمات"
                        },
                        new Band() {
                            NameEn="Gates",
                            NameAr="البوابات"
                        },
                        new Band() {
                            NameEn="Children's area",
                            NameAr="منطقة الاطفال"
                        },
                        new Band() {
                            NameEn="Roads and paths",
                            NameAr="الطرق و الممرات"
                        },
                        new Band() {
                            NameEn="Restaurants",
                            NameAr="المطاعم"
                        },
                        new Band() {
                            NameEn="Umbrellas",
                            NameAr="المظلات"
                        },
                        new Band() {
                            NameEn="Parking",
                            NameAr="المواقف"
                        },
                        new Band() {
                            NameEn="Guidance and Counseling",
                            NameAr="التوجيه و الارشاد"
                        },
                        new Band() {
                            NameEn="Signs",
                            NameAr="اللافتات الارشادية"
                        },
                        new Band() {
                            NameEn="Vegetation",
                            NameAr="الغطاء النباتى"
                        }
                      },
                      autoSave: true
                      );
            }
        }
    }
}
