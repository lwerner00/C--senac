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
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AllowUserToResizeRows = false;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(12, 12);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 62;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(776, 358);
            dgvFuncionarios.TabIndex = 0;
            dgvFuncionarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 389);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(154, 49);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(463, 389);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(154, 49);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(634, 389);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(154, 49);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(dgvFuncionarios);
            Name = "FrmTelaPrincipal";
            Text = "Tela principal";
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
    }
}