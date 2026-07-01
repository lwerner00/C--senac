namespace SistemaDeCadastroDeFuncionarios
{
    internal class FuncionarioClt : Funcionario
    {
        public FuncionarioClt
            (
           string nome,
           string cpf,
           string tipoFuncionario
            ) 
        { 
           Nome = nome;
           Cpf = cpf;
           TipoFuncionario = tipoFuncionario;
        }

        public double SalarioBase { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Documento: {Cpf}");
            Console.WriteLine($"Salário: {CalcularSalario()}");
            Console.WriteLine($"Tipo de funcionário: {TipoFuncionario}");
        }
    }
}
