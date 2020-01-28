using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mensagem mensa = new Mensagem();
           
            //mensa.Show();


              // vamos obter a linha da célula selecionada
              DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
              DataGridViewCell celula1 = dataGridView1.CurrentCell;

              // vamos exibir o índice da linha atual
              int indice = linhaAtual.Index;
              string conte = dataGridView1.CurrentCell.Value.ToString();
              MessageBox.Show("Imprimindo Receibo atual é: " + indice + " / " + conte);

              this.label2.Text = conte;

        }

        private void Recibo_Load(object sender, EventArgs e)
        {

            this.label2.Text = "";
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            //int seek_c = 0;
            //seek_c = Convert.ToInt32(this.textBox9.Text);

            //string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_ALUGUEL] ORDER BY ID_ALUGUEL ASC";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            conexao.Open();

            //criando o select e o objeto de consulta
            string sql = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_ALUGUEL] ORDER BY ID_ALUGUEL ASC";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Connection = conexao;
            cmd.CommandText = sql;

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
            conexao.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
