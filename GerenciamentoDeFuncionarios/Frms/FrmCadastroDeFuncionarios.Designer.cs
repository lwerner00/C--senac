namespace GerenciamentoDeFuncionarios
{
    partial class FrmCadastroDeFuncionarios
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
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSalario = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            groupBox2 = new GroupBox();
            rbAutonomo = new RadioButton();
            rbPj = new RadioButton();
            rbClt = new RadioButton();
            btnSalvar = new Button();
            lblErros = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(63, 57);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 88);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "João da Silva";
            txtNome.Size = new Size(293, 31);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "joao.silva@gmail.com";
            txtEmail.Size = new Size(293, 31);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(63, 152);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            label2.Click += label2_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(63, 269);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "2000 (Somente valor numéricos)";
            txtSalario.Size = new Size(293, 31);
            txtSalario.TabIndex = 5;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(63, 238);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 4;
            label3.Text = "Salário:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(429, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 68);
            groupBox1.TabIndex = 6;
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
            rbMasculino.Checked = true;
            rbMasculino.Location = new Point(15, 30);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(109, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masulino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAutonomo);
            groupBox2.Controls.Add(rbPj);
            groupBox2.Controls.Add(rbClt);
            groupBox2.Location = new Point(429, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 68);
            groupBox2.TabIndex = 7;
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
            rbAutonomo.CheckedChanged += radioButton1_CheckedChanged;
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
            rbPj.CheckedChanged += rbPj_CheckedChanged;
            // 
            // rbClt
            // 
            rbClt.AutoSize = true;
            rbClt.Checked = true;
            rbClt.Location = new Point(25, 33);
            rbClt.Name = "rbClt";
            rbClt.Size = new Size(64, 29);
            rbClt.TabIndex = 0;
            rbClt.TabStop = true;
            rbClt.Text = "CLT";
            rbClt.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(591, 371);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(154, 49);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.Font = new Font("Segoe UI", 10F);
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(63, 334);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 28);
            lblErros.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 365);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Senha123.";
            textBox1.Size = new Size(293, 31);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(63, 334);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 10;
            label4.Text = "Senha:";
            // 
            // FrmCadastroDeFuncionarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
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
            Name = "FrmCadastroDeFuncionarios";
            Text = "Cadastrar funcionário";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSalario;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private GroupBox groupBox2;
        private RadioButton rbAutonomo;
        private RadioButton rbPj;
        private RadioButton rbClt;
        private Button btnSalvar;
        private Label lblErros;
        private TextBox textBox1;
        private Label label4;
    }
}