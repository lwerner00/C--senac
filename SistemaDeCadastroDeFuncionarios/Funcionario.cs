namespace SistemaDeCadastroDeFuncionarios
{
    internal class Funcionario
    {
        public string Nome { get; protected set; }

        public string Cpf { get; protected set; }

        public string TipoFuncionario { get; protected set; }

        public virtual double  CalcularSalario()
        {
            return 0;
        }

        public virtual void ExibirDados() 
        {
            Console.WriteLine("Exibindo dados");
        }
    }

}
