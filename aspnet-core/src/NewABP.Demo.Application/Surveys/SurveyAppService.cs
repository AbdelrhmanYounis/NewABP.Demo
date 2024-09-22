using NewABP.Demo.Shared;
using NewABP.Demo.SurveyBands;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
namespace NewABP.Demo.Surveys
{
    public class SurveyAppService: BaseApplicationService, ISurveyAppService
    {
        private readonly IRepository<Survey, int> _surveyRepository;
        private readonly IRepository<SurveyBand, int> _surveyBandRepository;

        public SurveyAppService(IRepository<Survey,int> surveyRepository,IRepository<SurveyBand,int> surveyBandRepository)
        {
            _surveyRepository = surveyRepository;
            _surveyBandRepository = surveyBandRepository;
        }
        public async Task<ResponseDto> CreateSurvey(CreateSurveyDto model)
        {
            try
            {
                var survey = ObjectMapper.Map<CreateSurveyDto, Survey>(model);
                var surveyBand = ObjectMapper.Map<CreateSurveyDto, SurveyBand>(model);
               var surveyResult = await _surveyRepository.InsertAsync(survey, autoSave: true);
                surveyBand.SurveyId = surveyResult.Id;
                 var surveyBandResult = await _surveyBandRepository.InsertAsync(surveyBand, autoSave: true);
                if (surveyResult is null)
                {
                    return new ResponseDto
                    {
                        Success = false,
                        Message = "error while saving Survey",
                    };
                }
                if (surveyBandResult is null)
                {
                    return new ResponseDto
                    {
                        Success = false,
                        Message = "error while saving Survey Bands",
                    };
                }
                    return new ResponseDto
                    {
                        Success = true,
                        Message = "Survey created successfully",
                    };
            }
            catch (Exception ex)
            {
                return new ResponseDto
                {
                    Success = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
