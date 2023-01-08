using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Queries
{
    public class GetSubEducationHandler : IRequestHandler<GetSubEducationDto, SubEducationDto>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetSubEducationHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<SubEducationDto> Handle(GetSubEducationDto request, CancellationToken cancellationToken)
        {
            var subEducation = _dbContext.SubEducation.Include(m => m.Education).FirstOrDefault(m => m.Id == request.Id);

            return subEducation == null ? null : _mapper.Map<SubEducationDto>(subEducation);

        }
    }
}
