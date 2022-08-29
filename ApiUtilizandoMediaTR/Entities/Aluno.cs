namespace ApiUtilizandoMediaTR.Entities
{
    public class Aluno
    {
        public Aluno()
        {

        }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public Guid Matricula { get; set; }
    }
}
