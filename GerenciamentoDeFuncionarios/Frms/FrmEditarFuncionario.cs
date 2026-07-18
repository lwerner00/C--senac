using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmEditarFuncionario : Form
    {
        private int IdFuncionario;
        private Funcionario FuncionarioAtual;



        public FrmEditarFuncionario(int idFuncionario)
        {
            InitializeComponent();

            this.IdFuncionario = idFuncionario;

            Load += FrmEditarFuncionario_Load;
        }

        private async void FrmEditarFuncionario_Load(object? sender, EventArgs e)
        {
            FuncionarioAtual = await FuncionarioRepository.ObterPorId(IdFuncionario);

            txtNome.Text = FuncionarioAtual.Nome;
            txtNome.ReadOnly = true;
            txtEmail.Text = FuncionarioAtual.Email;
            txtSalario.Text = FuncionarioAtual.Salario.ToString();
            if (FuncionarioAtual.Sexo == 'M')
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
            }

            if (FuncionarioAtual.TipoDeContrato == "CLT")
            {
                rbClt.Checked = true;
            }
            else if (FuncionarioAtual.TipoDeContrato == "PJ")
            {
                rbPj.Checked = true;
            }
            else
            {
                rbAutonomo.Checked = true;
            }




        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string novoEmail = txtEmail.Text;
            decimal novoSalario = decimal.Parse(txtSalario.Text);
            char novoSexo = rbMasculino.Checked ? 'M' : 'F';
            string novoTipoContrato = rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";
            var dataDeAtualizacao = DateTime.Now;

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(FuncionarioAtual);
            Validator.TryValidateObject(FuncionarioAtual, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }
                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                FuncionarioAtual.SetEmail(novoEmail);
                FuncionarioAtual.SetSalario(novoSalario);
                FuncionarioAtual.SetSexo(novoSexo);
                FuncionarioAtual.SetTipoDeContrato(novoTipoContrato);
                FuncionarioAtual.DataDeAtualizacao(dataDeAtualizacao);

            }




            



        }
    }
}
