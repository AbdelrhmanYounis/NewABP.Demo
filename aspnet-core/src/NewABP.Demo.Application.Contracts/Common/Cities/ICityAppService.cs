using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Common.Cities
{
    public interface ICityAppService
    {
        Task<ResponseDto> GetByGovernorateId(int id);

    }
}
