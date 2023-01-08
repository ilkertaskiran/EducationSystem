using EducationSystem.APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

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
        public async Task<List<Education>> GetEducations()
        {
            var client = new RestClient("https://localhost:44346/get-educations");
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            //JsonConvert.DeserializeObject<RootObject>(json);

            List<Education> educationList = JsonConvert.DeserializeObject<List<Education>>(response.Content);


            return educationList;
        }
    }
}