using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Queries
{
    public class GetSubEducationsHandler : IRequestHandler<GetSubEducationsDto, List<SubEducationDto>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetSubEducationsHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<SubEducationDto>> Handle(GetSubEducationsDto request, CancellationToken cancellationToken)
        {
            var subEducations = _dbContext.SubEducation.Include(m => m.Education).Where(m => m.Education.Id == request.EducationId).ToList();

            return subEducations == null ? null : _mapper.Map<List<SubEducationDto>>(subEducations);

        }
    }
}
