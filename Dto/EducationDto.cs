using System.Text.Json.Serialization;

namespace BusinessLayer.Dto
{
    public class EducationDto : BaseRequest
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public List<SubEducationDto> SubTrainingList { get; set; }
    }
}
