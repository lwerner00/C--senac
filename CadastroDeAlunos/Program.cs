using System.Globalization;
using System.Linq;

namespace CadastroDeAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var lista = new List<Aluno>();
            bool continuarPrograma = true;
            while (continuarPrograma)
            {
                Console.WriteLine($"\n Cadastro de alunos");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine($" 1- Adicionar um aluno a lista \n 2- Remover um aluno da lista \n 3- Listar alunos cadastrados \n 4- Encerrar programa");
                int Escolha = int.Parse(Console.ReadLine());

                if (Escolha == 1)
                {
                    Console.WriteLine("Qual o nome do aluno?");
                    string nomeAluno = Console.ReadLine();

                    Console.WriteLine("Qual é o CPF do aluno?");
                    string cpfAluno = Console.ReadLine();
                    if (lista.Any(aluno => aluno.Cpf == cpfAluno))
                    {
                        Console.WriteLine("Erro: Já existe um aluno cadastrado com esse CPF!");
                    }
                    else
                    {

                        Console.WriteLine("Qual é a data de nascimento do aluno (DD/MM/AAAA)");
                        DateTime nascimentoAluno = DateTime.Parse(Console.ReadLine());

                       Guid Matricula = Guid.NewGuid();

                        var Aluno = new Aluno(nomeAluno, cpfAluno, nascimentoAluno, Matricula);
                        lista.Add(Aluno);
                        Console.WriteLine("Aluno adicionado!");

                    }

                }
                else if(Escolha == 2)
                {
                    Console.WriteLine("Digite o CPF do aluno q você deseja remover");
                    
                    foreach (var aluno in lista)
                    {
                        Console.WriteLine($"Nome:{aluno.Nome} CPF: {aluno.Cpf}" );
                    }
                    string cpfRemoverAluno = Console.ReadLine();
                    lista.RemoveAll(aluno => aluno.Cpf == cpfRemoverAluno);
                    
                    
                    
                    

                }
                else if (Escolha == 3)
                {
                    Console.WriteLine("Como você deseja listar: \n 1-Ordem de cadastro \n 2-Ordem por nome\n 3-Ordem por idade \n 4-Buscar aluno pela primeira letra do nome \n 5- Buscar aluno por CPF");
                    DateTime dataHoje = DateTime.Today;
                    int escolhaListar = int.Parse(Console.ReadLine());

                    if (escolhaListar == 1)
                    {
                        foreach (var aluno in lista)
                        {
                            int idade = dataHoje.Year - aluno.DataDeNascimento.Year;
                            Console.WriteLine("");
                            Console.WriteLine($"Nome: {aluno.Nome}");
                            Console.WriteLine($"CPF: {aluno.Cpf}");
                            Console.WriteLine("");
                        }
                    }else if (escolhaListar == 2)
                    {
                        foreach (var aluno in lista)
                        {
                            
                        }
                        var alunosOrdenadosPorNome = lista.OrderBy(aluno => aluno.Nome).ToList();
                        foreach(var aluno in alunosOrdenadosPorNome)
                        {
                            int idade = dataHoje.Year - aluno.DataDeNascimento.Year;
                            Console.WriteLine("");
                            Console.WriteLine($"Nome:{aluno.Nome}");
                            Console.WriteLine($"Idade: {idade}");
                            Console.WriteLine("");
                        }
                    }
                    else if(escolhaListar == 3)
                    {
                        foreach (var aluno in lista)
                        {

                        }
                        var alunosOrdenadosPorIdade = lista.OrderBy(aluno => aluno.DataDeNascimento).ToList();
                        foreach (var aluno in alunosOrdenadosPorIdade)
                        {
                            int idade = dataHoje.Year - aluno.DataDeNascimento.Year;
                            Console.WriteLine("");
                            Console.WriteLine($"Nome:{aluno.Nome}");
                            Console.WriteLine($"Idade: {idade}");
                            Console.WriteLine("");
                        }
                    }
                    else if(escolhaListar == 4)
                    {
                        string primeiraLetraBuscar = Console.ReadLine();

                        var alunosPrimeiraLetra = lista.Where(Aluno => Aluno.Nome.StartsWith(primeiraLetraBuscar.ToString(), StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine($"Alunos que começam com {alunosPrimeiraLetra}");
                        foreach(var aluno in alunosPrimeiraLetra)
                        {
                            int idade = dataHoje.Year - aluno.DataDeNascimento.Year;
                            Console.WriteLine("");
                            Console.WriteLine($"Nome: {aluno.Nome}");
                            Console.WriteLine($"Idade: {idade}");
                        }
                    }

                }
                else if (Escolha == 4)
                {
                    Console.WriteLine("Programa encerrado!");
                    continuarPrograma &= false;
                }
            }



        }
    }
}
