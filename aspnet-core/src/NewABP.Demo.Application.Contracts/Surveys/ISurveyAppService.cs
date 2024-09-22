using System.Threading.Tasks;
using NewABP.Demo.Shared;
namespace NewABP.Demo.Surveys
{
    public interface ISurveyAppService
    {
        Task<ResponseDto> CreateSurvey(CreateSurveyDto createSurveyDto);

    }
}
