using ApiUtilizandoMediaTR.Entities;
using ApiUtilizandoMediaTR.Services.Interfaces;

namespace ApiUtilizandoMediaTR.Services
{
    public class AlunoService : IAlunoService
    {
        public async Task<List<Aluno>> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno aluno = new Aluno()
            {
                Nome = "Davi",
                DataNascimento = "08/11/99",
                Matricula = Guid.NewGuid()
            };

            alunos.Add(aluno);

            aluno = new Aluno()
            {
                Nome = "Bruno",
                DataNascimento = "15/05/96",
                Matricula = Guid.NewGuid()
            };

            alunos.Add(aluno);

            return alunos;
        }
    }
}
