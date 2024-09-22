using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Parks
{
    public interface IParkAppService
    {
        Task<ResponseDto> GetByAreaId(int id);

    }
}
