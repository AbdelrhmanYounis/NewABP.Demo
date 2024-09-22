using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Common.Governorates
{
    public interface IGovernorateAppService
    {
        Task<ResponseDto> GetAll();

    }
}
