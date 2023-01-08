using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dto
{
    public class GetEducationDto : IRequest<EducationDto>
    {
        [Required]
        public int Id { get; set; }
    }
}
