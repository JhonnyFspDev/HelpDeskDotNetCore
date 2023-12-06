namespace HelpDeskDotNetCore
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
            lblId = new Label();
            lblEmail = new Label();
            txtId = new TextBox();
            txtEmail = new TextBox();
            lblAssunto = new Label();
            txtAssunto = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnEnviar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(75, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Identificação";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 56);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(107, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail Corporativo";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(73, 23);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(344, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(12, 100);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(50, 15);
            lblAssunto.TabIndex = 4;
            lblAssunto.Text = "Assunto";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(12, 118);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(391, 23);
            txtAssunto.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 144);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 162);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(523, 23);
            txtDescricao.TabIndex = 7;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(444, 250);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(91, 42);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(165, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(165, 27);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(370, 23);
            txtNome.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 304);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnEnviar);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtAssunto);
            Controls.Add(lblAssunto);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(lblEmail);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Chamado TI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblEmail;
        private TextBox txtId;
        private TextBox txtEmail;
        private Label lblAssunto;
        private TextBox txtAssunto;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Button btnEnviar;
        private Label lblNome;
        private TextBox txtNome;
    }
}