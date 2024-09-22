using AutoMapper;
using NewABP.Demo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Governorates
{
    public class GovernorateAppService: BaseApplicationService, IGovernorateAppService
    {
        private readonly IRepository<Governorate,int> _governorateRepository;
        private readonly IMapper _mapper;
        public GovernorateAppService(IRepository<Governorate, int> governorateRepository, IMapper mapper)
        {
            _governorateRepository = governorateRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetAll()
        {
            try
            {
                var items = await _governorateRepository.GetListAsync();
                IList<GovernorateDto> result = _mapper.Map<List<GovernorateDto>>(items.ToList());
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
