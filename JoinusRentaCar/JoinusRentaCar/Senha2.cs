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
    public partial class Senha2 : Form
    {
        public Senha2()
        {
            InitializeComponent();
        }

        private void Senha1_Load(object sender, EventArgs e)
        {
            var var_1 = Usuario.Login;

            this.label21.Text = "Usuário: " + var_1;


            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] ORDER BY ID_USUARIO_FUNC";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                        this.textBox2.Text = dr["SITUACAO"].ToString();
                        this.textBox3.Text = dr["USUARIO"].ToString();
                        this.textBox4.Text = dr["SENHA"].ToString();
                        this.textBox5.Text = dr["PERMISSAO"].ToString();

                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] ORDER BY ID_USUARIO_FUNC DESC";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                        this.textBox2.Text = dr["SITUACAO"].ToString();
                        this.textBox3.Text = dr["USUARIO"].ToString();
                        this.textBox4.Text = dr["SENHA"].ToString();
                        this.textBox5.Text = dr["PERMISSAO"].ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
                        string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] ORDER BY ID_USUARIO_FUNC ASC";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                        this.textBox2.Text = dr["SITUACAO"].ToString();
                        this.textBox3.Text = dr["USUARIO"].ToString();
                        this.textBox4.Text = dr["SENHA"].ToString();
                        this.textBox5.Text = dr["PERMISSAO"].ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            int seek = 0;

            if (this.textBox1.Text != null)
            {
                seek = Convert.ToInt32(this.textBox1.Text) + 1;
            }
            else
            {
                seek = 1;
            }


            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] WHERE ID_USUARIO_FUNC = " + seek + "";
            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                        this.textBox2.Text = dr["SITUACAO"].ToString();
                        this.textBox3.Text = dr["USUARIO"].ToString();
                        this.textBox4.Text = dr["SENHA"].ToString();
                        this.textBox5.Text = dr["PERMISSAO"].ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            int seek = 0;

            if (this.textBox1.Text != null)
            {
                seek = Convert.ToInt32(this.textBox1.Text) - 1;
            }
            else
            {
                seek = 1;
            }


            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] WHERE ID_USUARIO_FUNC = " + seek + "";
            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                        this.textBox2.Text = dr["SITUACAO"].ToString();
                        this.textBox3.Text = dr["USUARIO"].ToString();
                        this.textBox4.Text = dr["SENHA"].ToString();
                        this.textBox5.Text = dr["PERMISSAO"].ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seek_up = 0;
            seek_up = Convert.ToInt32(this.textBox1.Text);
            string ID_USUARIO_CLIENTE = this.textBox1.Text;
            int SITUACAO = Convert.ToInt32(this.textBox2.Text);
            string USUARIO = this.textBox3.Text;
            string SENHA = this.textBox4.Text;
            string PERMISSAO = this.textBox5.Text;

            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = "";

            string strSQLupd = "UPDATE TB_USUARIOS_FUNCIONARIOS SET   SITUACAO = " + SITUACAO + "," +
                                                            "USUARIO = '" + USUARIO + "'," +
                                                            "SENHA = '" + SENHA + "'," +
                                                            "PERMISSAO = '" + PERMISSAO + "' WHERE ID_USUARIO_FUNC = " + seek_up + "";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQLupd, conexao);
                    cmd.ExecuteNonQuery();
                    try
                    {
                        MessageBox.Show("Alterado com Sucesso !!!");

                    }
                    catch
                    {
                        MessageBox.Show("ERRO: Não foi possivel Alterar !!!");
                    }
                    conexao.Close();
                }
                catch
                {
                    MessageBox.Show("ERRO: Não foi possivel Alterar !!!");
                }

            }
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            int seek_c = 0;
            seek_c = Convert.ToInt32(this.textBox1.Text);

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] WHERE ID_USUARIO_FUNC = " + seek_c + "";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();
                    try
                    {


                        while (dr.Read())
                        {
                            this.textBox1.Text = dr["ID_USUARIO_FUNC"].ToString();
                            this.textBox2.Text = dr["SITUACAO"].ToString();
                            this.textBox3.Text = dr["USUARIO"].ToString();
                            this.textBox4.Text = dr["SENHA"].ToString();

                        }

                        if (dr.HasRows)
                        {
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro não Encontrado !!!");
                        }
                        dr.Close();
                        conexao.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Registro não Encontrado !!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Registro não Encontrado !!!");
                }

            }
            catch
            {
                MessageBox.Show("Registro não Encontrado !!!");
            }

        }

    }

}


 
