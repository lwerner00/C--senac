namespace GerenciamentoDeFuncionarios.Frms
{
    partial class FrmEditarFuncionario
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
            lblErros = new Label();
            btnSalvar = new Button();
            groupBox2 = new GroupBox();
            rbAutonomo = new RadioButton();
            rbPj = new RadioButton();
            rbClt = new RadioButton();
            groupBox1 = new GroupBox();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            txtSalario = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.Font = new Font("Segoe UI", 10F);
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(48, 321);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 28);
            lblErros.TabIndex = 19;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(576, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(154, 49);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAutonomo);
            groupBox2.Controls.Add(rbPj);
            groupBox2.Controls.Add(rbClt);
            groupBox2.Location = new Point(414, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 68);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de contrato";
            // 
            // rbAutonomo
            // 
            rbAutonomo.AutoSize = true;
            rbAutonomo.Location = new Point(198, 33);
            rbAutonomo.Name = "rbAutonomo";
            rbAutonomo.Size = new Size(124, 29);
            rbAutonomo.TabIndex = 8;
            rbAutonomo.Text = "Autônomo";
            rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbPj
            // 
            rbPj.AutoSize = true;
            rbPj.Location = new Point(121, 33);
            rbPj.Name = "rbPj";
            rbPj.Size = new Size(52, 29);
            rbPj.TabIndex = 1;
            rbPj.Text = "PJ";
            rbPj.UseVisualStyleBackColor = true;
            // 
            // rbClt
            // 
            rbClt.AutoSize = true;
            rbClt.Location = new Point(25, 33);
            rbClt.Name = "rbClt";
            rbClt.Size = new Size(64, 29);
            rbClt.TabIndex = 0;
            rbClt.Text = "CLT";
            rbClt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(414, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 68);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(162, 30);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(110, 29);
            rbFeminino.TabIndex = 7;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(15, 30);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(109, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.Text = "Masulino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(48, 256);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(293, 31);
            txtSalario.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(48, 225);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 14;
            label3.Text = "Salário:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 31);
            txtEmail.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(48, 139);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 12;
            label2.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(48, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(293, 31);
            txtNome.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // FrmEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErros);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSalario);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FrmEditarFuncionario";
            Text = "Edição de funcionário";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErros;
        private Button btnSalvar;
        private GroupBox groupBox2;
        private RadioButton rbAutonomo;
        private RadioButton rbPj;
        private RadioButton rbClt;
        private GroupBox groupBox1;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private TextBox txtSalario;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
    }
}