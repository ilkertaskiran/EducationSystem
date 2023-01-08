using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using MediatR;

namespace BusinessLayer.Commands
{
    public class PublishEducationHandler : IRequestHandler<PublishEducationDto, EducationDto>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public PublishEducationHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<EducationDto> Handle(PublishEducationDto request, CancellationToken cancellationToken)
        {
            int dbResult = 0;

            var education = _dbContext.Education.FirstOrDefault(m => m.Id == request.Id);
            if (education == null) return null;

            education.IsPublished = request.IsPublished;
            _dbContext.Education.Update(education);

            dbResult = _dbContext.SaveChanges();
            if(dbResult > 0) return _mapper.Map<EducationDto>(education);

            return null;
        }
    }
}
