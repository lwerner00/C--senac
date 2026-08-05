using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmLoginFuncionario : Form
    {
        private Funcionario funcionarioAtual;

        public FrmLoginFuncionario()
        {
            InitializeComponent();
            Load += FrmLoginFuncionario_Load;
        }

        private async void FrmLoginFuncionario_Load(object? sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            funcionarioAtual = await FuncionarioRepository.ObterPorId(int.Parse(txtMatricula.Text));

            string senhaDigita = txtSenha.Text;
            string hashDoBanco = funcionarioAtual.Senha;
            bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaDigita, hashDoBanco);

            if (txtMatricula.Text == funcionarioAtual.Id.ToString() && senhaValida)
            {
                int idFuncionarioEditar = int.Parse(txtMatricula.Text);
                bool EhAdm = false;
                this.Hide();
                new FrmTelaPrincipal(EhAdm, idFuncionarioEditar).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Matrícula ou senha incorretas.",
                    "Erro ao fazer login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
