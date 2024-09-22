using AutoMapper;
using NewABP.Demo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Areas
{
    public class AreaAppService: BaseApplicationService, IAreaAppService
    {
        private readonly IRepository<Area,int> _areaRepository;
        private readonly IMapper _mapper;
        public AreaAppService(IRepository<Area, int> areaRepository, IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetByCityId(int id)
        {
            try { 
            var items=(await _areaRepository.GetQueryableAsync()).Where(x=>x.CityId==id);
            IList<AreaDto> result=_mapper.Map<List<AreaDto>>(items);
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
