using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;

namespace BusinessLayer.Commands
{
    public class CreateSubEducationHandler : IRequestHandler<SubEducationDto, BaseResponse>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateSubEducationHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<BaseResponse> Handle(SubEducationDto request, CancellationToken cancellationToken)
        {
            BaseResponse response = new();
            int dbResult = 0;

            var education = _dbContext.Education.FirstOrDefault(m => m.Id == request.EducationId);
            if(education == null)
            {
                response.ResponseCode = 2;
                response.ResponseMessage = "Wrong EducationId!";
                return response;
            }

            var subEducation = _mapper.Map<SubEducation>(request);
            subEducation.Education = education;

            _dbContext.SubEducation.Add(subEducation);
            dbResult = _dbContext.SaveChanges();

            if (dbResult > 0)
            {
                response.ResponseCode = 0;
                response.ResponseMessage = "Successfull Operation.";
            }
            else
            {
                response.ResponseCode = 1;
                response.ResponseMessage = "Unsuccessfull Operation!";
            }

            return response;

        }
    }
}
