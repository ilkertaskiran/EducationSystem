using BusinessLayer.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : BaseController
    {

        private readonly ILogger<EducationController> _logger;

        public EducationController(ILogger<EducationController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Add education.
        /// </summary>
        /// <returns></returns>
        [HttpPost("/add-education")]
        public async Task<ActionResult<BaseResponse>> AddEducation([FromBody] EducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yap�s� kurulabilir

            if (result == null) return NotFound("No service available");

            return Ok(result);
        }

        /// <summary>
        /// Get education.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-education")]
        public async Task<ActionResult<EducationDto>> GetEducation([FromQuery] GetEducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yap�s� kurulabilir

            return Ok(result);
        }

        /// <summary>
        /// Get education list.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-educations")]
        public async Task<ActionResult<List<EducationDto>>> GetEducations()
        {
            var result = await Mediator.Send(new GetEducationsDto());

            //_logger.LogError(); log yap�s� kurulabilir

            return Ok(result);
        }

        /// <summary>
        /// Publish education.
        /// </summary>
        /// <returns></returns>
        [HttpPut("/publish-education")]
        public async Task<ActionResult<BaseResponse>> PublishEducation([FromBody] PublishEducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yap�s� kurulabilir

            return Ok(result);
        }

    }
}