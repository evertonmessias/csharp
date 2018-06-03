namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Saida = new System.Windows.Forms.Label();
            this.Resposta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.Masc = new System.Windows.Forms.RadioButton();
            this.Femin = new System.Windows.Forms.RadioButton();
            this.mulher_gorda = new System.Windows.Forms.PictureBox();
            this.homem_gordo = new System.Windows.Forms.PictureBox();
            this.mulher_magra = new System.Windows.Forms.PictureBox();
            this.homem_magro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mulher_gorda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homem_gordo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulher_magra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homem_magro)).BeginInit();
            this.SuspendLayout();
            // 
            // Peso
            // 
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(161, 145);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(116, 31);
            this.Peso.TabIndex = 0;
            // 
            // Altura
            // 
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(161, 212);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(116, 31);
            this.Altura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cálculo do IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "(m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "IMC = ";
            // 
            // Saida
            // 
            this.Saida.AutoSize = true;
            this.Saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saida.ForeColor = System.Drawing.Color.Red;
            this.Saida.Location = new System.Drawing.Point(135, 283);
            this.Saida.Name = "Saida";
            this.Saida.Size = new System.Drawing.Size(0, 31);
            this.Saida.TabIndex = 8;
            // 
            // Resposta
            // 
            this.Resposta.AutoSize = true;
            this.Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta.ForeColor = System.Drawing.Color.Red;
            this.Resposta.Location = new System.Drawing.Point(170, 285);
            this.Resposta.Name = "Resposta";
            this.Resposta.Size = new System.Drawing.Size(0, 29);
            this.Resposta.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(204, 341);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "everton.messias@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sexo  :";
            // 
            // Masc
            // 
            this.Masc.AutoSize = true;
            this.Masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masc.Location = new System.Drawing.Point(141, 86);
            this.Masc.Name = "Masc";
            this.Masc.Size = new System.Drawing.Size(98, 24);
            this.Masc.TabIndex = 14;
            this.Masc.TabStop = true;
            this.Masc.Text = "Masculino";
            this.Masc.UseVisualStyleBackColor = true;
            // 
            // Femin
            // 
            this.Femin.AutoSize = true;
            this.Femin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femin.Location = new System.Drawing.Point(308, 87);
            this.Femin.Name = "Femin";
            this.Femin.Size = new System.Drawing.Size(92, 24);
            this.Femin.TabIndex = 15;
            this.Femin.TabStop = true;
            this.Femin.Text = "Feminino";
            this.Femin.UseVisualStyleBackColor = true;
            // 
            // mulher_gorda
            // 
            this.mulher_gorda.Image = global::WindowsFormsApplication1.Properties.Resources.mulher_gorda;
            this.mulher_gorda.Location = new System.Drawing.Point(480, 250);
            this.mulher_gorda.Name = "mulher_gorda";
            this.mulher_gorda.Size = new System.Drawing.Size(60, 100);
            this.mulher_gorda.TabIndex = 19;
            this.mulher_gorda.TabStop = false;
            this.mulher_gorda.Visible = false;
            // 
            // homem_gordo
            // 
            this.homem_gordo.Image = global::WindowsFormsApplication1.Properties.Resources.homem_gordo;
            this.homem_gordo.Location = new System.Drawing.Point(480, 250);
            this.homem_gordo.Name = "homem_gordo";
            this.homem_gordo.Size = new System.Drawing.Size(60, 100);
            this.homem_gordo.TabIndex = 18;
            this.homem_gordo.TabStop = false;
            this.homem_gordo.Visible = false;
            // 
            // mulher_magra
            // 
            this.mulher_magra.Image = global::WindowsFormsApplication1.Properties.Resources.mulher_magra;
            this.mulher_magra.Location = new System.Drawing.Point(480, 250);
            this.mulher_magra.Name = "mulher_magra";
            this.mulher_magra.Size = new System.Drawing.Size(60, 100);
            this.mulher_magra.TabIndex = 17;
            this.mulher_magra.TabStop = false;
            this.mulher_magra.Visible = false;
            // 
            // homem_magro
            // 
            this.homem_magro.Image = global::WindowsFormsApplication1.Properties.Resources.homem_magro;
            this.homem_magro.Location = new System.Drawing.Point(480, 250);
            this.homem_magro.Name = "homem_magro";
            this.homem_magro.Size = new System.Drawing.Size(60, 100);
            this.homem_magro.TabIndex = 16;
            this.homem_magro.TabStop = false;
            this.homem_magro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 363);
            this.Controls.Add(this.mulher_gorda);
            this.Controls.Add(this.homem_gordo);
            this.Controls.Add(this.mulher_magra);
            this.Controls.Add(this.homem_magro);
            this.Controls.Add(this.Femin);
            this.Controls.Add(this.Masc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resposta);
            this.Controls.Add(this.Saida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cálculo do IMC";
            ((System.ComponentModel.ISupportInitialize)(this.mulher_gorda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homem_gordo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulher_magra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homem_magro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Saida;
        private System.Windows.Forms.Label Resposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Masc;
        private System.Windows.Forms.RadioButton Femin;
        private System.Windows.Forms.PictureBox homem_magro;
        private System.Windows.Forms.PictureBox mulher_magra;
        private System.Windows.Forms.PictureBox homem_gordo;
        private System.Windows.Forms.PictureBox mulher_gorda;
    }
}

