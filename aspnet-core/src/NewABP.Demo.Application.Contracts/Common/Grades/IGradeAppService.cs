using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Common.Grades
{
    public interface IGradeAppService
    {
        Task<ResponseDto> GetAll();

    }
}
