using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Common.Governorates
{
    public class GovernorateDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Governorate, int> _governorateRepository;

        public GovernorateDataSeederContributor(IRepository<Governorate, int> governorateRepository)
        {
            _governorateRepository = governorateRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _governorateRepository.GetCountAsync() < 1)
            {
                await _governorateRepository.InsertManyAsync(
                      new List<Governorate>()
                      {
                        new Governorate() {
                            NameEn="Cairo",
                            NameAr="القاهرة"
                        },
                        new Governorate() {
                            NameEn="alex",
                            NameAr="الاسكندرية"
                        }
                      },
                      autoSave: true
                      );
            }
        }
    }
}
