using AutoMapper;
using NewABP.Demo.Surveys;

namespace NewABP.Demo.Mapper
{
    public class SurveyMapperProfile:Profile
    {
        public SurveyMapperProfile()
        {
            CreateMap<Survey, CreateSurveyDto>().ReverseMap();
        }
    }
}
