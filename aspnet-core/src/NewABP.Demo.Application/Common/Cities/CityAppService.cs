using AutoMapper;
using NewABP.Demo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Cities
{
    public class CityAppService: BaseApplicationService, ICityAppService
    {
        private readonly IRepository<City,int> _cityRepository;
        private readonly IMapper _mapper;
        public CityAppService(IRepository<City, int> cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetByGovernorateId(int id)
        {
            try { 
            var items=(await _cityRepository.GetQueryableAsync()).Where(x=>x.GovernorateId==id);
            IList<CityDto> result=_mapper.Map<List<CityDto>>(items);
            return new ResponseDto
            {
                Success = true,
                ResultDto = result
            };
        }
            catch (Exception ex)
            {
                return new ResponseDto
                {
                    Success = false,
                    Message = ex.Message
    };
}
        }
    }
}
