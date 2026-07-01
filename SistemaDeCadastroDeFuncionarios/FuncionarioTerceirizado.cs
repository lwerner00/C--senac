namespace SistemaDeCadastroDeFuncionarios
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public FuncionarioTerceirizado
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

        public double HorasTrabalhadas {  get; set; }

        public double ValorHora { get; set; }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
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
