using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dto
{
    public class GetSubEducationsDto : IRequest<List<SubEducationDto>>
    {
        public int EducationId { get; set; }
    }
}
