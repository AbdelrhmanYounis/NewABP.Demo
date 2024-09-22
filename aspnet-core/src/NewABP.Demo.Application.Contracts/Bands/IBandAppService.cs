using NewABP.Demo.Shared;
using System.Threading.Tasks;

namespace NewABP.Demo.Bands
{
    public interface IBandAppService
    {
        Task<ResponseDto> GetAll();

    }
}
