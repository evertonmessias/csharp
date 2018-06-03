using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Masc.Checked && !Femin.Checked || Peso.Text == "" || Altura.Text == "")
            {
                Saida.Text = "Erro, informe todos os valores!";
            }
            else
            {
                decimal peso, altura, imc;
                int IMC;

                if (!decimal.TryParse(Peso.Text, out peso) || !decimal.TryParse(Altura.Text, out altura))
                {
                    Saida.Text = "Erro, use somente numeros!";
                }
                else
                {
                    peso = Convert.ToDecimal(Peso.Text);
                    altura = Convert.ToDecimal(Altura.Text);

                    if (peso <= 0 || altura <= 0)
                    {
                        Saida.Text = "ERRO, use valores maior que 0";
                    }
                    else
                    {
                        //formula:
                        imc = peso / (altura * altura);

                        IMC = Convert.ToInt16(imc);

                        Saida.Text = Convert.ToString(IMC);


                        if (IMC <= 20)
                        {
                            Resposta.Text = ", ABAIXO DO PESO";
                            if (Masc.Checked) 
                            { 
                                homem_magro.Visible = true;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = false;
                            }
                            else if (Femin.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = true;
                                mulher_gorda.Visible = false;
                            }
                        }
                        else if (IMC > 20 && IMC <= 25)
                        {
                            Resposta.Text = ", PESO NORMAL";
                            if (Masc.Checked)
                            {
                                homem_magro.Visible = true;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = false;
                            }
                            else if (Femin.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = true;
                                mulher_gorda.Visible = false;
                            }
                        }
                        else if (IMC > 25 && IMC <= 30)
                        {
                            Resposta.Text = ", ACIMA DO PESO";
                            if (Masc.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = true;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = false;
                            }
                            else if (Femin.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = true;
                            }
                        }
                        else if (IMC > 30 && IMC <= 35)
                        {
                            Resposta.Text = ", OBESIDADE";
                            if (Masc.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = true;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = false;
                            }
                            else if (Femin.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = true;
                            }
                        }
                        else
                        {
                            Resposta.Text = ", OBESIDADE ELEVADA";
                            if (Masc.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = true;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = false;
                            }
                            else if (Femin.Checked)
                            {
                                homem_magro.Visible = false;
                                homem_gordo.Visible = false;
                                mulher_magra.Visible = false;
                                mulher_gorda.Visible = true;
                            }
                        }

                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
