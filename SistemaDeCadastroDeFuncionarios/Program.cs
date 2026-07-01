using System.Security.AccessControl;

namespace SistemaDeCadastroDeFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de cadastro de funcionários");

            Console.WriteLine("");

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Cadastrar funcionário.");
            Console.WriteLine("2 - Listar funcionários.");
            Console.WriteLine("3 - Sair.");
            var FuncionarioTerceirizado = new FuncionarioTerceirizado("", "", "Terceirizado");
            var FuncionarioClt = new FuncionarioClt("", "", "CLT");
            var FuncionarioEstagiario = new FuncionarioEstagiario("", "", "Estagiario");
            bool Continuar;


            while (Continuar = true)
            {


                try
                {
                    int Escolha = int.Parse(Console.ReadLine());

                    if (Escolha == 1)
                    {
                        Console.WriteLine($"Qual é seu tipo \n 1- CLT \n 2- Estagiario \n 3- Terceirizado");
                        int tipoFuncionario = int.Parse(Console.ReadLine());
                        if (tipoFuncionario == 1)
                        {
                            Console.WriteLine("Qual o nome do funcionário");
                            string NomeFuncionario = Console.ReadLine();
                            Console.WriteLine("Qual seu CPF?");
                            string CpfFuncionario = Console.ReadLine();
                            FuncionarioClt = new FuncionarioClt(NomeFuncionario, CpfFuncionario, "CLT");
                            Console.WriteLine("Qual é o seu salário?");
                            FuncionarioClt.SalarioBase = int.Parse(Console.ReadLine());
                            Console.WriteLine("Funcionário cadastrado!");


                        }
                        else if (tipoFuncionario == 2)
                        {
                            Console.WriteLine("Qual o nome do funcionário");
                            string NomeFuncionario = Console.ReadLine();
                            Console.WriteLine("Qual seu CPF?");
                            string CpfFuncionario = Console.ReadLine();
                            FuncionarioEstagiario = new FuncionarioEstagiario(NomeFuncionario, CpfFuncionario, "Estagiario");
                            Console.WriteLine("Qual é o valor de sua bolsa auxílio?");
                            FuncionarioEstagiario.BolsaAuxilio = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o valor do seu vale transporte?");
                            FuncionarioEstagiario.ValeTransporte = int.Parse(Console.ReadLine());
                            Console.WriteLine("Funcionário cadastrado!");
                        }
                        else if (tipoFuncionario == 3)
                        {
                            Console.WriteLine("Qual o nome do funcionário");
                            string NomeFuncionario = Console.ReadLine();
                            Console.WriteLine("Qual seu CPF?");
                            string CpfFuncionario = Console.ReadLine();
                            FuncionarioTerceirizado = new FuncionarioTerceirizado(NomeFuncionario, CpfFuncionario, "Terceirizado");
                            Console.WriteLine("Quantas horas ele trabalha?");
                            FuncionarioTerceirizado.HorasTrabalhadas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o valor da hora?");
                            FuncionarioTerceirizado.ValorHora = int.Parse(Console.ReadLine());
                            Console.WriteLine("Funcionário cadastrado!");
                        }
                    }
                    else if (Escolha == 2)
                    {
                        Console.WriteLine("Lista de Funcionarios cadastrados:");
                        var lista = new List<Funcionario> { FuncionarioClt, FuncionarioEstagiario, FuncionarioTerceirizado };

                        foreach (var funcionario in lista)
                        {
                            funcionario.ExibirDados();
                        }


                    }
                    else if (Escolha == 3)
                    {
                        Console.WriteLine("Programa encerrado");
                        Continuar = false;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("A opção escolhida não é válida, escolha entre 1, 2 ou 3");
                }
            }
        }
    }
}
