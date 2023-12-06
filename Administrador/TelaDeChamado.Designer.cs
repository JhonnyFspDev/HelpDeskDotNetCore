namespace Administrador
{
    partial class TelaDeChamado
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
            lvwChamado = new ListView();
            colId = new ColumnHeader();
            colNome = new ColumnHeader();
            colEmail = new ColumnHeader();
            colAssunto = new ColumnHeader();
            colDescricao = new ColumnHeader();
            btnCarregaDados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Chamados dos Usuários";
            // 
            // lvwChamado
            // 
            lvwChamado.Columns.AddRange(new ColumnHeader[] { colId, colNome, colEmail, colAssunto, colDescricao });
            lvwChamado.Location = new Point(12, 37);
            lvwChamado.Name = "lvwChamado";
            lvwChamado.Size = new Size(724, 324);
            lvwChamado.TabIndex = 2;
            lvwChamado.UseCompatibleStateImageBehavior = false;
            lvwChamado.View = View.Details;
            lvwChamado.SelectedIndexChanged += lvwChamado_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colNome
            // 
            colNome.Text = "Nome";
            colNome.Width = 80;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 80;
            // 
            // colAssunto
            // 
            colAssunto.Text = "Assunto";
            colAssunto.Width = 150;
            // 
            // colDescricao
            // 
            colDescricao.Text = "Descrição";
            colDescricao.Width = 700;
            // 
            // btnCarregaDados
            // 
            btnCarregaDados.Location = new Point(26, 388);
            btnCarregaDados.Name = "btnCarregaDados";
            btnCarregaDados.Size = new Size(101, 50);
            btnCarregaDados.TabIndex = 3;
            btnCarregaDados.Text = "Carregar Dados";
            btnCarregaDados.UseVisualStyleBackColor = true;
            btnCarregaDados.Click += btnCarregaDados_Click;
            // 
            // TelaDeChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 450);
            Controls.Add(btnCarregaDados);
            Controls.Add(lvwChamado);
            Controls.Add(label1);
            Name = "TelaDeChamado";
            Text = "TelaDeChamado";
            Load += TelaDeChamado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvwChamado;
        private ColumnHeader colId;
        private ColumnHeader colEmail;
        private ColumnHeader colNome;
        private ColumnHeader colAssunto;
        private ColumnHeader colDescricao;
        private Button btnCarregaDados;
    }
}