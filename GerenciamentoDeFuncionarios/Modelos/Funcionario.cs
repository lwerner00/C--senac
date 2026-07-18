using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Funcionario
    {
        public Funcionario(string nome,
            string email,
            char sexo,
            string tipoContrato,
            decimal salario,
            DateTime dataDeCadastro)
        {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
        }

        public Funcionario(int id, string nome, string email, char sexo, string tipoDeContrato, decimal salario, DateTime dataDeCadastro, DateTime? dataDeAtualizacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
            DataDeAtualizacao = dataDeAtualizacao;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 caracteres e 255.")]
        public string Nome { get; private set; }


        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [EmailAddress(ErrorMessage = "O 'Email' é inválido")]
        public string Email { get; private set; }

        public char Sexo { get; private set; }

        public string TipoDeContrato { get; private set; }

        public decimal Salario { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeAtualizacao { get; set; }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetSexo(char sexo)
        {
            Sexo = sexo;
        }

        public void SetSalario(decimal salario)
        {
            Salario = salario;
        }

        public void SetTipoDeContrato(string tipoDeContrato)
        {
            TipoDeContrato = tipoDeContrato;
        }
    }
}
