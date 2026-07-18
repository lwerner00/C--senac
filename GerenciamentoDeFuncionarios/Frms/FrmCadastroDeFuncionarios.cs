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

namespace GerenciamentoDeFuncionarios
{
    public partial class FrmCadastroDeFuncionarios : Form
    {
        public FrmCadastroDeFuncionarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataDeCadastro = DateTime.Now;

            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataDeCadastro);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                // adiciona os erros stringBuilder e exibe na tela
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                    //"o campo tal é obrigatorio"
                    //"o campo outro tal é obrigatorio"
                }
                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                await FuncionarioRepository.Adicionar(funcionario);
                this.Close();
            }

            //await FuncionarioRepository.Adicionar(funcionario);


        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if(!char.IsDigit(e.KeyChar) && e.KeyChar != ',')  
            {
             e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text == string.Empty)
            {
                e.Handled = true;
            }

        }
    }
}
