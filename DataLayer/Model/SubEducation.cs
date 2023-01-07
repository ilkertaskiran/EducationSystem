namespace DataLayer.Model
{
    public class SubEducation : BaseEntity
    {
        public Education Education { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
