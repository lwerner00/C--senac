using GerenciamentoDeFuncionarios.Frms;

namespace GerenciamentoDeFuncionarios
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnSouAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLoginAdm().ShowDialog();
            this.Show();
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
