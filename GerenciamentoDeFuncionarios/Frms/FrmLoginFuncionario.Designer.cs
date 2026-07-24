namespace GerenciamentoDeFuncionarios.Frms
{
    partial class FrmLoginFuncionario
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
            btnEntrar = new Button();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            txtSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(318, 278);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(140, 78);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(299, 131);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(176, 31);
            txtMatricula.TabIndex = 6;
            txtMatricula.UseSystemPasswordChar = true;
            txtMatricula.TextChanged += txtSenha_TextChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 15F);
            lblMatricula.Location = new Point(318, 87);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(140, 41);
            lblMatricula.TabIndex = 5;
            lblMatricula.Text = "Matrícula";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(299, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(176, 31);
            txtSenha.TabIndex = 9;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(338, 176);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 8;
            label1.Text = "Senha";
            // 
            // FrmLoginFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Name = "FrmLoginFuncionario";
            Text = "Login do funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private TextBox txtSenha;
        private Label label1;
    }
}