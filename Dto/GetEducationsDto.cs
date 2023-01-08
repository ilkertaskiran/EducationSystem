using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dto
{
    public class GetEducationsDto : IRequest<List<EducationDto>>
    {
    }
}
