using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System.ComponentModel;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmTelaPrincipal : Form
    {
        private bool EhAdmin;
        private int IdFuncionarioEditar;

        public FrmTelaPrincipal(bool EhAdm, int idFuncionarioEditar)
        {
            InitializeComponent();

            this.EhAdmin = EhAdm;

            this.IdFuncionarioEditar = idFuncionarioEditar;

            Load += FrmTelaPrincipal_Load;
        }

        private async void FrmTelaPrincipal_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();

            if (EhAdmin)
            {
                btnNovo.Visible = true;
                btnExcluir.Visible = true;
            }
            else
            {
                btnNovo.Visible = false;
                btnExcluir.Visible = false;
            }
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
            dgvFuncionarios.Columns["Senha"].Visible = false;
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

            if (EhAdmin || idFuncionario == IdFuncionarioEditar)
            {

                new FrmEditarFuncionario(idFuncionario).ShowDialog();
                await AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Você só tem permissão para editar o seu próprio cadastro.",
                    "Acesso Negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeOuEmailFuncionario = txtNomeOuEmail.Text;
            string TipoDeContrato = CbTipoFuncionario.Text;
            var funcionariosPorNome = await FuncionarioRepository.BuscarFuncionarioPorNomeOuEmail(nomeOuEmailFuncionario, TipoDeContrato);
            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionariosPorNome.ToList());
            var listaFuncionarios = funcionariosPorNome?.ToList();

            if (funcionariosPorNome == null || !listaFuncionarios.Any())
            {
                lblErro.Text = "Nenhum funcionário encontrado.";
            }
            else
            {
                lblErro.Text = string.Empty;
                dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionariosPorNome.ToList());
            }
        }

        private async void btnLimpar_Click(object sender, EventArgs e)
        {
            await AtualizarTabela();
            txtNomeOuEmail.Clear();
            CbTipoFuncionario.SelectedIndex = -1;
        }

        private async void btnNovoDependente_Click(object sender, EventArgs e)
        {
            int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

            if (EhAdmin || idFuncionario == IdFuncionarioEditar)
            {

                new FrmCadastroDeDependentes(idFuncionario).ShowDialog();
                await AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Você só tem permissão para adicionar dependentes ao seu próprio cadastro.",
                    "Acesso Negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
