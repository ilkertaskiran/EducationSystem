using AutoMapper;
using BusinessLayer.Dto;
using DataLayer;
using DataLayer.Model;
using MediatR;

namespace BusinessLayer.Commands
{
    public class CreateEducationHandler : IRequestHandler<EducationDto, BaseResponse>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateEducationHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<BaseResponse> Handle(EducationDto request, CancellationToken cancellationToken)
        {
            int dbResult = 0;

            //var education = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EducationDto, Education>())).Map<Education>(request);
            var education = _mapper.Map<Education>(request);


            //Education education = new()
            //{
            //    Name = "mustafa",
            //    CreatedTime = DateTime.Now,
            //    EndDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    UpdatedTime = DateTime.Now,
            //    Status = "Published"
            //};

            var today = DateTime.Now;

            if(today >= education.StartDate && today <= education.EndDate) 
                education.IsPublished= true;
            else
                education.IsPublished= false;

            _dbContext.Education.Add(education);
            dbResult = _dbContext.SaveChanges();

            BaseResponse response = new();
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
