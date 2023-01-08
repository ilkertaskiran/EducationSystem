using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;

namespace BusinessLayer.Queries
{
    public class GetEducationHandler : IRequestHandler<GetEducationDto, EducationDto>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetEducationHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<EducationDto> Handle(GetEducationDto request, CancellationToken cancellationToken)
        {
            var education = _dbContext.Education.FirstOrDefault(m => m.Id == request.Id);

            return education == null ? null : _mapper.Map<EducationDto>(education);

        }
    }
}
