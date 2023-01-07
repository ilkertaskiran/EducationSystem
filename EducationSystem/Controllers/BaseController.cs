using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationSystem.API.Controllers
{
    public class BaseController: ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ?? HttpContext.RequestServices.GetService<ISender>();
    }
}
