using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Common.Grades
{
    public class GradeDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Grade, int> _gradeRepository;

        public GradeDataSeederContributor(IRepository<Grade, int> gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _gradeRepository.GetCountAsync() < 1)
            {
                await _gradeRepository.InsertManyAsync(
                      new List<Grade>()
                      {
                        new Grade() {
                            NameEn="Very Satisfied",
                            NameAr="راض جدا"
                        },
                        new Grade() {
                            NameEn="Satisfied",
                            NameAr="راض"},
                        new Grade() {
                            NameEn= "Neutral",
                            NameAr="محايد"
                      },
                        new Grade() {
                            NameEn="Dissatisfied",
                            NameAr="غير راض"
                      },
                        new Grade() {
                            NameEn= "Very Dissatisfied",
                            NameAr="غير راض جدا"
                      }
                      },
                      autoSave: true
                      );
            }
        }
    }
}
