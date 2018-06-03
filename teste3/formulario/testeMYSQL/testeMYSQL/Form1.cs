using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testeMYSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;userid=root;database=teste01;password=";
            string query = "INSERT INTO cadastro (id, nome, mail) VALUES (NULL, @nome,@mail)";
            MySqlConnection CONEXAO = new MySqlConnection(conexao);
            try
            {
                CONEXAO.Open();
                MessageBox.Show("Conexão OK");
                MySqlCommand INSERT = new MySqlCommand(query, CONEXAO);
                INSERT.Parameters.AddWithValue("@nome", Nome.Text);
                INSERT.Parameters.AddWithValue("@mail", Email.Text);
                INSERT.ExecuteNonQuery();
                CONEXAO.Clone();
                Resposta.Text = "OK";
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string conexao = "server=localhost;userid=root;database=teste01;password=";
            string query = "select * from cadastro";
            MySqlConnection CONEXAO = new MySqlConnection(conexao);
            try
            {
                CONEXAO.Open();
                DataSet conexaoDataset = new DataSet();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter(query, CONEXAO);
                conexaoAdapter.Fill(conexaoDataset, "cadastro");
                tabela.DataSource = conexaoDataset;
                tabela.DataMember = "cadastro";
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                CONEXAO.Close();
            }

        }
    }
}