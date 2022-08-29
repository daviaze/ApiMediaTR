using ApiUtilizandoMediaTR.Entities;
using ApiUtilizandoMediaTR.Handlers.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiUtilizandoMediaTR.Controllers
{
    [ApiController]
    [Route("controller")]
    public class AlunoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlunoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAlunos()
        {
            return Ok(_mediator.Send(new GetAlunosRequest { }));
        }
    }
}
