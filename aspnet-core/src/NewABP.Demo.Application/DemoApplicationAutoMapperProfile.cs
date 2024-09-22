using AutoMapper;
using NewABP.Demo.Bands;
using NewABP.Demo.Common.Areas;
using NewABP.Demo.Common.Cities;
using NewABP.Demo.Common.Governorates;
using NewABP.Demo.Common.Grades;
using NewABP.Demo.Parks;

namespace NewABP.Demo;

public class DemoApplicationAutoMapperProfile : Profile
{
    public DemoApplicationAutoMapperProfile()
    {
        CreateMap<Governorate,GovernorateDto>().ReverseMap();
        CreateMap<City,CityDto>().ReverseMap();
        CreateMap<Area,AreaDto>().ReverseMap();
        CreateMap<Park,ParkDto>().ReverseMap();
        CreateMap<Band,BandDto>().ReverseMap();
        CreateMap<Grade,GradeDto>().ReverseMap();        
    }
}
