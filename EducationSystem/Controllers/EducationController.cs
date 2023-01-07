using BusinessLayer.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : BaseController
    {
        /// <summary>
        /// Adding education.
        /// </summary>
        /// <returns></returns>
        [HttpPost("/add-education")]
        public async Task<ActionResult<BaseResponse>> AddEducation([FromBody] EducationDto request)
        {
            var result = await Mediator.Send(request);

            if (result == null) return NotFound("No service available");

            return Ok(result);
        }

    }
}