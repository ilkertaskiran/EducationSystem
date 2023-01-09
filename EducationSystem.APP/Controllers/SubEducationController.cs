using EducationSystem.APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace EducationSystem.APP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubEducationController : ControllerBase
    {
        private readonly ILogger<SubEducationController> _logger;

        public SubEducationController(ILogger<SubEducationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("get-sub-educations-by-id")]
        public async Task<List<SubEducation>> GetSubEducations(int id)
        {
            var client = new RestClient("https://localhost:44346/get-sub-education");
            var request = new RestRequest().AddParameter("id", id); ;
            var response = await client.GetAsync(request);

            //JsonConvert.DeserializeObject<RootObject>(json);

            List<SubEducation> subEducationList = JsonConvert.DeserializeObject<List<SubEducation>>(response.Content);


            return subEducationList;
        }
    }
}