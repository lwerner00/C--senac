namespace SistemaDeCadastroDeFuncionarios
{
    internal class FuncionarioEstagiario : Funcionario
    {
        public FuncionarioEstagiario
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

        public double BolsaAuxilio { get; set; }

        public double ValeTransporte { get; set; }

        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
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
