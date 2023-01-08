using Microsoft.AspNetCore.Mvc;
using RestSharp.Authenticators;
using RestSharp;
using System.Threading;

namespace EducationSystem.APP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : ControllerBase
    {
        private readonly ILogger<EducationController> _logger;

        public EducationController(ILogger<EducationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetEducations()
        {
            return StatusCode(StatusCodes.Status202Accepted);
            //var client = new RestClient("/get-educations");
            //var request = new RestRequest();
            //var response = await client.GetAsync(request);

            //return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}