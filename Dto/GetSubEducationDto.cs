using MediatR;

namespace BusinessLayer.Dto
{
    public class GetSubEducationDto : IRequest<SubEducationDto>
    {
        public int Id { get; set; }
    }
}
