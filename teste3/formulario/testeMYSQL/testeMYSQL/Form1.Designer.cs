namespace testeMYSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Resposta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(52, 320);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(194, 20);
            this.Nome.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(52, 355);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(194, 20);
            this.Email.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resposta
            // 
            this.Resposta.AutoSize = true;
            this.Resposta.Location = new System.Drawing.Point(366, 343);
            this.Resposta.Name = "Resposta";
            this.Resposta.Size = new System.Drawing.Size(13, 13);
            this.Resposta.TabIndex = 5;
            this.Resposta.Text = "?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "LISTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(12, 12);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(683, 299);
            this.tabela.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 520);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Resposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MYSQL";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resposta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tabela;
    }
}

