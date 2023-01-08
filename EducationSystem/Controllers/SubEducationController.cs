using BusinessLayer.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubEducationController : BaseController
    {

        private readonly ILogger<SubEducationController> _logger;

        public SubEducationController(ILogger<SubEducationController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Add sub education.
        /// </summary>
        /// <returns></returns>
        [HttpPost("/add-sub-education")]
        public async Task<ActionResult<BaseResponse>> AddSubEducation([FromBody] SubEducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yapýsý kurulabilir

            if (result == null) return NotFound("No service available");

            return Ok(result);
        }

        /// <summary>
        /// get sub education.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-sub-education")]
        public async Task<ActionResult<SubEducationDto>> GetSubEducation([FromQuery] GetSubEducationDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yapýsý kurulabilir

            return Ok(result);
        }

        /// <summary>
        /// Get sub education list.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-sub-educations")]
        public async Task<ActionResult<List<SubEducationDto>>> GetSubEducations([FromQuery]GetSubEducationsDto request)
        {
            var result = await Mediator.Send(request);

            //_logger.LogError(); log yapýsý kurulabilir

            return Ok(result);
        }

    }
}