using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Dependente
    {
        public Dependente(string name, DateTime dataDeNascimento, string parentesco)
        {
            Name = name;
            DataDeNascimento = dataDeNascimento;
            Parentesco = parentesco;
        }

        public int Id { get; set; }

        public string Name { get; private set; }

        public DateTime DataDeNascimento { get; private set; }

        public string Parentesco {  get; private set; }
    }
}
