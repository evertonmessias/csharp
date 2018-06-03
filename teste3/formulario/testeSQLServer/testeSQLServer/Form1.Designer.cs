namespace testeSQLServer
{
    partial class Form1
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
            this.listar = new System.Windows.Forms.Button();
            this.inserir = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(12, 296);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(121, 72);
            this.listar.TabIndex = 0;
            this.listar.Text = "LISTAR";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click_1);
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(601, 296);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(85, 75);
            this.inserir.TabIndex = 2;
            this.inserir.Text = "INSERIR";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click_1);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(384, 296);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(211, 20);
            this.nome.TabIndex = 3;
            this.nome.Text = "nome";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(384, 322);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 20);
            this.email.TabIndex = 4;
            this.email.Text = "email";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(384, 348);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(211, 20);
            this.telefone.TabIndex = 5;
            this.telefone.Text = "telefone";
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(13, 13);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(674, 277);
            this.tabela.TabIndex = 6;
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(139, 296);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(122, 72);
            this.alterar.TabIndex = 7;
            this.alterar.Text = "ALTERAR";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 382);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.listar);
            this.Name = "Form1";
            this.Text = "SQL";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button alterar;
    }
}

