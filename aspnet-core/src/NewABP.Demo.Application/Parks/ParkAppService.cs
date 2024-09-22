using AutoMapper;
using NewABP.Demo.Parks;
using NewABP.Demo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Parks
{
    public class ParkAppService: BaseApplicationService, IParkAppService
    {
        private readonly IRepository<Park,int> _parkRepository;
        private readonly IMapper _mapper;
        public ParkAppService(IRepository<Park, int> parkRepository, IMapper mapper)
        {
            _parkRepository = parkRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetByAreaId(int id)
        {
            try { 
            var items=(await _parkRepository.GetQueryableAsync()).Where(x=>x.AreaId==id);
            IList<ParkDto> result=_mapper.Map<List<ParkDto>>(items);
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
