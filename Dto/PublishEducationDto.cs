using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dto
{
    public class PublishEducationDto : IRequest<EducationDto>
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool IsPublished { get; set; }

    }
}
