using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Common.Areas
{
    public interface IAreaAppService
    {
        Task<ResponseDto> GetByCityId(int id);

    }
}
