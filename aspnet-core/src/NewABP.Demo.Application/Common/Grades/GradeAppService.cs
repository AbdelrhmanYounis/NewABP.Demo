using AutoMapper;
using NewABP.Demo.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NewABP.Demo.Common.Grades
{
    public class GradeAppService: BaseApplicationService, IGradeAppService
    {
        private readonly IRepository<Grade,int> _gradeRepository;
        private readonly IMapper _mapper;
        public GradeAppService(IRepository<Grade, int> gradeRepository, IMapper mapper)
        {
            _gradeRepository = gradeRepository;
            _mapper = mapper;
        }
        public async Task<ResponseDto> GetAll()
        {
            try { 
            var items=await _gradeRepository.GetListAsync();
            IList<GradeDto> result=_mapper.Map<List<GradeDto>>(items);
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
