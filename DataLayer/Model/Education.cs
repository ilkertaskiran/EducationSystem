using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Education : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPublished { get; set; }
    }
}
