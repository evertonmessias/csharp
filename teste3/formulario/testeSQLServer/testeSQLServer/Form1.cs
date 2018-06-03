using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testeSQLServer
{
    public partial class Form1 : Form
    {        
        string conexao = @"server=SAMSUNGRV411\SQLEXPRESS;database=teste;Trusted_Connection = true";
        string query = "select * from agenda2";
        SqlConnection CONEXAO;
        SqlDataAdapter adaptador;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        // ************ LISTAR ********************************

        private void listar_Click_1(object sender, EventArgs e)
        {
            CONEXAO = new SqlConnection(conexao);
            adaptador = new SqlDataAdapter(query, CONEXAO);
            try
            {
                CONEXAO.Open();
                adaptador.Fill(ds, "cadastro");
                tabela.DataSource = ds;
                tabela.DataMember = "cadastro";
                CONEXAO.Close();
            }
            catch
            {
                MessageBox.Show("ERRO"); CONEXAO.Close();
            }
        }

        // *********************** ALTERAR ********************
        
        private void alterar_Click(object sender, EventArgs e)
        {
            CONEXAO = new SqlConnection(conexao);
            adaptador = new SqlDataAdapter(query, CONEXAO);            
            try
            {
                CONEXAO.Open();
                SqlCommandBuilder ALTERA = new SqlCommandBuilder(adaptador);
                DataSet changes = ds.GetChanges(); 
                adaptador.Fill(ds, "cadastro");
                if (changes != null)
                {
                    adaptador.Update(changes, "cadastro");
                    MessageBox.Show("Dados Alterados OK");
                }
                CONEXAO.Close();                
            }
            catch
            {
                MessageBox.Show("ERRO");CONEXAO.Close();
            }
        }

        // ***************** INSERIR *****************************

        private void inserir_Click_1(object sender, EventArgs e)
        {
            CONEXAO = new SqlConnection(conexao);
            adaptador = new SqlDataAdapter(query, CONEXAO);    
            try
            {
                CONEXAO.Open();
                SqlCommand INSERT = new SqlCommand(query, CONEXAO);
                INSERT.Parameters.AddWithValue("@Nome", nome.Text);
                INSERT.Parameters.AddWithValue("@Email", email.Text);
                INSERT.Parameters.AddWithValue("@Telefone", telefone.Text);
                INSERT.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos OK");
                CONEXAO.Close();
            }
            catch
            {
                MessageBox.Show("ERRO");CONEXAO.Close();
            }
        }        
    }
}