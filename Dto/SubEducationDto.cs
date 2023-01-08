namespace BusinessLayer.Dto
{
    public class SubEducationDto : BaseRequest
    {
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

    }
}