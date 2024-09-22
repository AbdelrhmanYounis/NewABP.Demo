using AutoMapper;
using NewABP.Demo.SurveyBands;
using NewABP.Demo.Surveys;

namespace NewABP.Demo.Mapper
{
    public class SurveyBandMapperProfile : Profile
    {
        public SurveyBandMapperProfile()
        {
            CreateMap<SurveyBand, CreateSurveyDto>().ReverseMap();
        }
    }
}
