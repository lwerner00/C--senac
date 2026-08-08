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
    public partial class FrmCadastroDeDependentes : Form
    {

        private int IdFuncionario;
        public FrmCadastroDeDependentes(int idFuncionario)
        {
            InitializeComponent();

            this.IdFuncionario = idFuncionario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string NomeDependente = txtNome.Text;
            DateTime NascimentoDependente = DateTime.Parse(txtDataDeNascimento.Text);
            string ParentescoDependente = txtParentesco.Text;
            var Dependente = new Dependente(NomeDependente, NascimentoDependente, ParentescoDependente);
        }
    }
}
