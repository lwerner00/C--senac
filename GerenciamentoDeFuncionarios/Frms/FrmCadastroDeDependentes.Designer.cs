namespace GerenciamentoDeFuncionarios.Frms
{
    partial class FrmCadastroDeDependentes
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
            txtParentesco = new TextBox();
            label3 = new Label();
            txtDataDeNascimento = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(233, 266);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Filho, Esposa, Mãe...";
            txtParentesco.Size = new Size(293, 31);
            txtParentesco.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(320, 235);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 10;
            label3.Text = "Parentesco:";
            // 
            // txtDataDeNascimento
            // 
            txtDataDeNascimento.Location = new Point(233, 180);
            txtDataDeNascimento.Name = "txtDataDeNascimento";
            txtDataDeNascimento.PlaceholderText = "DD/MM/AAAA";
            txtDataDeNascimento.Size = new Size(293, 31);
            txtDataDeNascimento.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(292, 149);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 8;
            label2.Text = "Data de nascimento:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(233, 85);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "João da Silva";
            txtNome.Size = new Size(293, 31);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(343, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(292, 375);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(154, 49);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCadastroDeDependentes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtParentesco);
            Controls.Add(label3);
            Controls.Add(txtDataDeNascimento);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FrmCadastroDeDependentes";
            Text = "FrmCadastroDeDependentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParentesco;
        private Label label3;
        private TextBox txtDataDeNascimento;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnSalvar;
    }
}