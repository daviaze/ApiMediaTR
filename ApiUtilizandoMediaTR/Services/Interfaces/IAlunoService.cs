using ApiUtilizandoMediaTR.Entities;

namespace ApiUtilizandoMediaTR.Services.Interfaces
{
    public interface IAlunoService
    {
        public Task<List<Aluno>> GetAlunos();
    }
}
