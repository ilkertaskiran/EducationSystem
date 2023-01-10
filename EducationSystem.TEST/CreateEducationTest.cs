using AutoMapper;
using BusinessLayer.Commands;
using BusinessLayer.Dto;
using DataLayer;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DataLayer.Model;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using System.Reflection.Metadata;

namespace EducationSystem.TEST
{
    public class CreateEducationTest
    {
        private readonly DbContextOptions<AppDbContext> _contextOptions;
        private readonly IMapper _mapper;
        private readonly Mock<Microsoft.EntityFrameworkCore.DbSet<Education>> _mockSet;
        private readonly Mock<AppDbContext> _mockContext;

        public CreateEducationTest()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EducationDto, Education>(); });

            _mapper = config.CreateMapper();
            _contextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=edu123;Integrated Security=true;Pooling=true;")
            .Options;

            _mockSet = new Mock<Microsoft.EntityFrameworkCore.DbSet<Education>>() { };
            _mockContext = new Mock<AppDbContext>(_contextOptions);
            _mockContext.Setup(m => m.Education).Returns(_mockSet.Object);
        }

        [Fact]
        public async Task CreateEducationCorrect()
        {
            EducationDto educationRequest = new()
            {
                Name = "Education Name",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };

            var handler = new CreateEducationHandler(_mockContext.Object, _mapper);
            var actual = await handler.Handle(educationRequest, CancellationToken.None);

            Assert.True(actual != null);
        }

        [Fact]
        public async Task CreateEducationIncorrect()
        {
            EducationDto educationRequest = new()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };

            var handler = new CreateEducationHandler(_mockContext.Object, _mapper);
            var actual = await handler.Handle(educationRequest, CancellationToken.None);


            Assert.True(actual.ResponseCode == 1);
        }

    }
}
