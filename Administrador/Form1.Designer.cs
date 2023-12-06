namespace Administrador
{
    partial class Form1
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
            btnLogin = new Button();
            pnlLogin = new Panel();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(71, 118);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Location = new Point(43, 198);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(231, 177);
            pnlLogin.TabIndex = 1;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(71, 50);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(157, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(71, 15);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(157, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(13, 50);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(3, 14);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 450);
            Controls.Add(pnlLogin);
            Name = "Form1";
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Panel pnlLogin;
        private TextBox txtUsuario;
        private Label lblSenha;
        private Label lblUsuario;
        private TextBox txtSenha;
    }
}