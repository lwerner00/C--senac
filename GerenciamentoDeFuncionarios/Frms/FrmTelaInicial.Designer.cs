namespace GerenciamentoDeFuncionarios
{
    partial class FrmTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSouAdmin = new Button();
            btnSouFuncionario = new Button();
            SuspendLayout();
            // 
            // btnSouAdmin
            // 
            btnSouAdmin.Location = new Point(315, 119);
            btnSouAdmin.Name = "btnSouAdmin";
            btnSouAdmin.Size = new Size(159, 76);
            btnSouAdmin.TabIndex = 0;
            btnSouAdmin.Text = "Sou administrador";
            btnSouAdmin.UseVisualStyleBackColor = true;
            btnSouAdmin.Click += btnSouAdmin_Click;
            // 
            // btnSouFuncionario
            // 
            btnSouFuncionario.Location = new Point(315, 230);
            btnSouFuncionario.Name = "btnSouFuncionario";
            btnSouFuncionario.Size = new Size(159, 76);
            btnSouFuncionario.TabIndex = 1;
            btnSouFuncionario.Text = "Sou funcionário";
            btnSouFuncionario.UseVisualStyleBackColor = true;
            btnSouFuncionario.Click += btnSouFuncionario_Click;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSouFuncionario);
            Controls.Add(btnSouAdmin);
            Name = "FrmTelaInicial";
            Text = "Tela inicial";
            Load += FrmTelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSouAdmin;
        private Button btnSouFuncionario;
    }
}
