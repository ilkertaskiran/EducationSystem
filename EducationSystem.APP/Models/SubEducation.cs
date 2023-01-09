namespace EducationSystem.APP.Models
{
    public class SubEducation
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}