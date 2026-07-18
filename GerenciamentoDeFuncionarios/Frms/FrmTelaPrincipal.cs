using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();

            Load += FrmTelaPrincipal_Load;
        }

        private async void FrmTelaPrincipal_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroDeFuncionarios().ShowDialog();
            await AtualizarTabela();
        }

        private async Task AtualizarTabela()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();
            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            //pegar o nome do funcionario e exiber uma mensagem perguntando se o usuario tem certeza q deseja excluir
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {nomeFuncionario}?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se sim, exclui o funcionario do banco e exibe mensagem de sucesso
            if (retorno == DialogResult.Yes)
            {
                int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

                await FuncionarioRepository.DeletarPorId(idFuncionario);

                MessageBox.Show($"O funcionário {nomeFuncionario} foi excluido com sucesso", "Exclusão do funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await AtualizarTabela();
            }
            //se não,fecha a messageBox e volta pra tela principal
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

            new FrmEditarFuncionario(idFuncionario).ShowDialog();
            await AtualizarTabela();
        }
    }
}
