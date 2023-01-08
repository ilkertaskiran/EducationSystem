using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;

namespace BusinessLayer.Queries
{
    public class GetEducationsHandler : IRequestHandler<GetEducationsDto, List<EducationDto>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetEducationsHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<EducationDto>> Handle(GetEducationsDto request, CancellationToken cancellationToken)
        {
            var educations = _dbContext.Education.ToList();

            return educations == null ? null : _mapper.Map<List<EducationDto>>(educations);

        }
    }
}
