using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Common.Cities
{
    public class CityDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<City, int> _cityRepository;

        public CityDataSeederContributor(IRepository<City, int> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _cityRepository.GetCountAsync() < 1)
            {
                await _cityRepository.InsertManyAsync(
                      new List<City>()
                      {
                        new City() {
                            NameEn="Helwan",
                            NameAr="حلوان",
                            GovernorateId=1
                        },
                        new City() {
                            NameEn="Maadi",
                            NameAr="المعادى",
                            GovernorateId=1
                        },
                        new City() {
                            NameEn="Smouha",
                            NameAr="سموحة",
                            GovernorateId=2
                        },
                        new City() {
                            NameEn="Miami",
                            NameAr="ميامي",
                            GovernorateId=2
                        }
                      },
                      autoSave: true
                      );
            }
        }
    }
}
