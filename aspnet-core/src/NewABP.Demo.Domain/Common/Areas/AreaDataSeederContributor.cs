using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Common.Areas
{
    public class AreaDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Area, int> _areaRepository;

        public AreaDataSeederContributor(IRepository<Area, int> areaRepository)
        {
            _areaRepository = areaRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _areaRepository.GetCountAsync() < 1)
            {
                await _areaRepository.InsertManyAsync(
                      new List<Area>()
                      {
                        new Area() {
                        NameEn="15th Of May",
                        NameAr="15 مايو",
                        CityId=1,
                        },new Area() {
                        NameEn="Hadayek Helwan",
                        NameAr="حدائق حلوان",
                        CityId=1,
                        },new Area() {
                        NameEn="Hadayek Maadi",
                        NameAr="حدائق المعادي",
                        CityId=2,
                        },new Area() {
                        NameEn="Maadi Degla",
                        NameAr="المعادي دجلة",
                        CityId=2,
                        },new Area() {
                        NameEn="Area 1",
                        NameAr="منطقة 1",
                        CityId=3,
                        },new Area() {
                        NameEn="Area 2",
                        NameAr="منطقة 2",
                        CityId=3,
                        },new Area() {
                        NameEn="Area 1",
                        NameAr="منطقة 1",
                        CityId=4,
                        },new Area() {
                        NameEn="Area 2",
                        NameAr="منطقة 2",
                        CityId=4,
                        }
                      }, autoSave: true
                      );
            }
        }
    }
}
