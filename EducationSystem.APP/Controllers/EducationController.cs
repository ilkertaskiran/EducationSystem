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
        [Route("get-educations")]
        public async Task<List<Education>> GetEducations()
        {
            var client = new RestClient("https://localhost:44346/get-educations");
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            //JsonConvert.DeserializeObject<RootObject>(json);

            List<Education> educationList = JsonConvert.DeserializeObject<List<Education>>(response.Content);


            return educationList;
        }

        [HttpPost]
        [Route("add-education")]
        public async Task<PostResponse> AddEducation([FromBody] AddEducation educationRequest)
        {
            var client = new RestClient("https://localhost:44346");
            var request = new RestRequest("/add-education", Method.Post);
            
            request.AddJsonBody(educationRequest);
            var response = client.Execute(request);

            var result = JsonConvert.DeserializeObject<PostResponse>(response.Content);

            return result;
        }
    }
}