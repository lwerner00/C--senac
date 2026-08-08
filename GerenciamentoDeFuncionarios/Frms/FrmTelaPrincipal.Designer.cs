namespace GerenciamentoDeFuncionarios.Frms
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFuncionarios = new DataGridView();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtNomeOuEmail = new TextBox();
            CbTipoFuncionario = new ComboBox();
            btnBuscar = new Button();
            btnLimpar = new Button();
            lblErro = new Label();
            btnNovoDependente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AllowUserToResizeRows = false;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(11, 10);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 62;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(698, 247);
            dgvFuncionarios.TabIndex = 0;
            dgvFuncionarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 7.5F);
            btnNovo.Location = new Point(571, 281);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(139, 41);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 7.5F);
            btnEditar.Location = new Point(427, 327);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 41);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Ver/Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 7.5F);
            btnExcluir.Location = new Point(571, 327);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 41);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNomeOuEmail
            // 
            txtNomeOuEmail.Font = new Font("Segoe UI", 9F);
            txtNomeOuEmail.Location = new Point(11, 262);
            txtNomeOuEmail.Name = "txtNomeOuEmail";
            txtNomeOuEmail.PlaceholderText = "Nome ou Email do funcionário que deseja buscar";
            txtNomeOuEmail.Size = new Size(363, 31);
            txtNomeOuEmail.TabIndex = 5;
            // 
            // CbTipoFuncionario
            // 
            CbTipoFuncionario.FormattingEnabled = true;
            CbTipoFuncionario.Items.AddRange(new object[] { "CLT", "PJ", "Autonomo" });
            CbTipoFuncionario.Location = new Point(11, 293);
            CbTipoFuncionario.Name = "CbTipoFuncionario";
            CbTipoFuncionario.Size = new Size(164, 29);
            CbTipoFuncionario.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 327);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(139, 41);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(156, 327);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(139, 41);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI", 8F);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(181, 297);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 21);
            lblErro.TabIndex = 9;
            // 
            // btnNovoDependente
            // 
            btnNovoDependente.Font = new Font("Segoe UI", 7.5F);
            btnNovoDependente.Location = new Point(426, 281);
            btnNovoDependente.Name = "btnNovoDependente";
            btnNovoDependente.Size = new Size(139, 41);
            btnNovoDependente.TabIndex = 10;
            btnNovoDependente.Text = "Novo Dependente";
            btnNovoDependente.UseVisualStyleBackColor = true;
            btnNovoDependente.Click += btnNovoDependente_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 378);
            Controls.Add(btnNovoDependente);
            Controls.Add(lblErro);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpar);
            Controls.Add(CbTipoFuncionario);
            Controls.Add(txtNomeOuEmail);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(dgvFuncionarios);
            Font = new Font("Segoe UI", 8F);
            Name = "FrmTelaPrincipal";
            Text = "Tela principal";
            Load += FrmTelaPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtNomeOuEmail;
        private ComboBox CbTipoFuncionario;
        private Button btnBuscar;
        private Button btnLimpar;
        private Label lblErro;
        private Button btnNovoDependente;
    }
}