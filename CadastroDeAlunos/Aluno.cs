namespace CadastroDeAlunos
{
    internal class Aluno
    {
        public Aluno
            (
            string nome,
            string cpf,
            DateTime dataDeNascimento,
            Guid matricula
            ) 
        { 
            Nome = nome;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
            Matricula = matricula;
        }

        public string Nome { get; private set; }

        public string Cpf { get; private set;}

        public DateTime DataDeNascimento { get; private set;}

        public Guid Matricula { get; private set;}
    }
}
