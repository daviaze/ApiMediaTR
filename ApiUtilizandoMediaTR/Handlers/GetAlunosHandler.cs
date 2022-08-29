using ApiUtilizandoMediaTR.Entities;
using ApiUtilizandoMediaTR.Handlers.Request;
using ApiUtilizandoMediaTR.Services.Interfaces;
using MediatR;

namespace ApiUtilizandoMediaTR.Handlers
{
    public class GetAlunosHandler : IRequestHandler<GetAlunosRequest, List<Aluno>>
    {
        readonly private IAlunoService _alunoService;

        public GetAlunosHandler(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<List<Aluno>> Handle(GetAlunosRequest request, CancellationToken cancellationToken)
        {
            return await _alunoService.GetAlunos();
        }
    }
}
