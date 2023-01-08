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
        /// Adding education.
        /// </summary>
        /// <returns></returns>
        [HttpPost("/add-education")]
        public async Task<ActionResult<BaseResponse>> AddEducation([FromBody] EducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yapýsý kurulabilir

            if (result == null) return NotFound("No service available");

            return Ok(result);
        }

        /// <summary>
        /// Adding education.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-education")]
        public async Task<ActionResult<EducationDto>> GetEducation([FromQuery] GetEducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yapýsý kurulabilir

            return Ok(result);
        }

        /// <summary>
        /// Adding education.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-educations")]
        public async Task<ActionResult<List<EducationDto>>> GetEducations()
        {
            var result = await Mediator.Send(new GetEducationsDto());

            //_logger.LogError(); log yapýsý kurulabilir

            return Ok(result);
        }

    }
}