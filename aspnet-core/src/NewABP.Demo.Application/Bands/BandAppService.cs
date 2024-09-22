using AutoMapper;
using NewABP.Demo.Bands;
using NewABP.Demo.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Bands
{
    public class BandAppService: BaseApplicationService, IBandAppService
    {
        private readonly IRepository<Band,int> _bandRepository;
        private readonly IMapper _mapper;
        public BandAppService(IRepository<Band, int> bandRepository, IMapper mapper)
        {
            _bandRepository = bandRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetAll()
        {
            var items=await _bandRepository.GetListAsync();
            IList<BandDto> result=_mapper.Map<List<BandDto>>(items);
            return new ResponseDto
            {
                Success = true,
                ResultDto = result
            };
        }

    }
}
