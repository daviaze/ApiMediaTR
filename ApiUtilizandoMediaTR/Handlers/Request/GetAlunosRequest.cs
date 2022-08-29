using ApiUtilizandoMediaTR.Entities;
using MediatR;

namespace ApiUtilizandoMediaTR.Handlers.Request
{
    public class GetAlunosRequest : IRequest<List<Aluno>>
    {
    }
}
