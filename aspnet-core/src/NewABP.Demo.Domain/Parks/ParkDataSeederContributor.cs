using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Parks
{
    public class ParkDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Park, int> _parkRepository;

        public ParkDataSeederContributor(IRepository<Park, int> parkRepository)
        {
            _parkRepository = parkRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _parkRepository.GetCountAsync() < 1)
            {
                await _parkRepository.InsertManyAsync(
                      new List<Park>()
                      {
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=1
                        },
                        new Park() {
                            NameEn="Park 2",
                            NameAr="المنتزه 2",
                            AreaId=1
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=2
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=3
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=4
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=5
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=6
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=7
                        },
                        new Park() {
                            NameEn="Park 1",
                            NameAr="المنتزه 1",
                            AreaId=8
                        },
                        new Park() {
                            NameEn="Park 2",
                            NameAr="المنتزه 2",
                            AreaId=8
                        },
                        new Park() {
                            NameEn="Park 3",
                            NameAr="المنتزه 3",
                            AreaId=8
                        }
                      },
                      autoSave: true
                      );
            }
        }
    }
}
