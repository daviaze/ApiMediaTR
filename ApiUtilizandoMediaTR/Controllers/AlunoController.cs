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
            Aluno davi = new Aluno()
            {
                Nome = "Davi",
                DataNascimento = "08/11/99",
                Matricula = Guid.NewGuid()
            };

            return Ok(_mediator.Send(new GetAlunosRequest { }));
        }
    }
}
