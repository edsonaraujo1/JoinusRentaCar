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
    public partial class Clientes : Form
    {

            //public string var_1 = Usuario.Login;
        
        public Clientes()
        {

            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            var var_1 = Usuario.Login;

                this.label21.Text = "Usuário: " + var_1;

                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;
                //int seek_c = 0;
                //seek_c = Convert.ToInt32(this.textBox9.Text);


                string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] ORDER BY ID_CLIENTE ASC";

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
                            this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                            this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                            this.textBox4.Text = dr["SITUACAO"].ToString();
                            this.textBox5.Text = dr["DOCUMENTO"].ToString();
                            this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                            this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                            this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                            this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                            this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                            this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                            this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                            this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                            this.textBox14.Text = dr["CEP"].ToString();
                            this.textBox15.Text = dr["LOGRADOURO"].ToString();
                            this.textBox16.Text = dr["ENDERECO"].ToString();
                            this.textBox17.Text = dr["END_NUMERO"].ToString();
                            this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                            this.textBox19.Text = dr["BAIRRO"].ToString();
                            this.textBox20.Text = dr["CIDADE"].ToString();
                            this.textBox21.Text = dr["UF"].ToString();

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

                // ALIMENTA GRID


                //string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_ALUGUEL] ORDER BY ID_ALUGUEL ASC";

                SqlConnection conexaoX = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                conexaoX.Open();

                //criando o select e o objeto de consulta
                string sql = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_ALUGUEL] WHERE ID_CLIENTE = " + this.textBox1.Text + "";
                SqlCommand cmdX = new SqlCommand(sql, conexaoX);
                cmdX.Connection = conexaoX;
                cmdX.CommandText = sql;

                // cria o dataadapter...
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmdX;

                // preenche o dataset...
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = dataSet.Tables[0].TableName;
                conexaoX.Close();



            // FIM DO GRID


        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
            this.button10.Enabled = false;


            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            this.textBox3.Text = " ";
            this.textBox4.Text = " ";
            this.textBox5.Text = " ";
            this.textBox6.Text = " ";
            this.textBox7.Text = " ";
            this.textBox8.Text = " ";
            this.textBox9.Text = " ";
            this.textBox10.Text = " ";
            this.textBox11.Text = " ";
            this.textBox12.Text = " ";
            this.textBox13.Text = " ";
            this.textBox14.Text = " ";
            this.textBox15.Text = " ";
            this.textBox16.Text = " ";
            this.textBox17.Text = " ";
            this.textBox18.Text = " ";
            this.textBox19.Text = " ";
            this.textBox20.Text = " ";
            this.textBox21.Text = " ";

            this.textBox2.Text = DateTime.Now.ToString("d");
            this.textBox3.Text = DateTime.Now.ToString("d");
            this.button11.Visible = true;
            this.button12.Visible = true;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox4.Text = "1";
            this.textBox4.Enabled = false;
            this.textBox5.Focus();

            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] ORDER BY ID_CLIENTE DESC";

            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

            try
            {
                conexao.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand(strSQL, conexao);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int novcodigo;
                        string codigo = dr["ID_CLIENTE"].ToString();
                        int acumul = Convert.ToInt32(codigo);

                        acumul += 1;
                        novcodigo = acumul;
                        this.textBox1.Text = novcodigo.ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                { }

            }
            catch
            { }


        
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] ORDER BY ID_CLIENTE ASC";

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
                        this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["DOCUMENTO"].ToString();
                        this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                        this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                        this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                        this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                        this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                        this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                        this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                        this.textBox14.Text = dr["CEP"].ToString();
                        this.textBox15.Text = dr["LOGRADOURO"].ToString();
                        this.textBox16.Text = dr["ENDERECO"].ToString();
                        this.textBox17.Text = dr["END_NUMERO"].ToString();
                        this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                        this.textBox19.Text = dr["BAIRRO"].ToString();
                        this.textBox20.Text = dr["CIDADE"].ToString();
                        this.textBox21.Text = dr["UF"].ToString();

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

        private void button6_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] ORDER BY ID_CLIENTE DESC";

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
                        this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["DOCUMENTO"].ToString();
                        this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                        this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                        this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                        this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                        this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                        this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                        this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                        this.textBox14.Text = dr["CEP"].ToString();
                        this.textBox15.Text = dr["LOGRADOURO"].ToString();
                        this.textBox16.Text = dr["ENDERECO"].ToString();
                        this.textBox17.Text = dr["END_NUMERO"].ToString();
                        this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                        this.textBox19.Text = dr["BAIRRO"].ToString();
                        this.textBox20.Text = dr["CIDADE"].ToString();
                        this.textBox21.Text = dr["UF"].ToString();

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE ID_CLIENTE = " + seek + "";

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
                        this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["DOCUMENTO"].ToString();
                        this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                        this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                        this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                        this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                        this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                        this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                        this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                        this.textBox14.Text = dr["CEP"].ToString();
                        this.textBox15.Text = dr["LOGRADOURO"].ToString();
                        this.textBox16.Text = dr["ENDERECO"].ToString();
                        this.textBox17.Text = dr["END_NUMERO"].ToString();
                        this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                        this.textBox19.Text = dr["BAIRRO"].ToString();
                        this.textBox20.Text = dr["CIDADE"].ToString();
                        this.textBox21.Text = dr["UF"].ToString();

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE ID_CLIENTE = " + seek + "";

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
                        this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["DOCUMENTO"].ToString();
                        this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                        this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                        this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                        this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                        this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                        this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                        this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                        this.textBox14.Text = dr["CEP"].ToString();
                        this.textBox15.Text = dr["LOGRADOURO"].ToString();
                        this.textBox16.Text = dr["ENDERECO"].ToString();
                        this.textBox17.Text = dr["END_NUMERO"].ToString();
                        this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                        this.textBox19.Text = dr["BAIRRO"].ToString();
                        this.textBox20.Text = dr["CIDADE"].ToString();
                        this.textBox21.Text = dr["UF"].ToString();

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
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            this.textBox3.Text = " ";
            this.textBox4.Text = " ";
            this.textBox5.Text = " ";
            this.textBox6.Text = " ";
            this.textBox7.Text = " ";
            this.textBox8.Text = " ";
            this.textBox9.Text = " ";
            this.textBox10.Text = " ";
            this.textBox11.Text = " ";
            this.textBox12.Text = " ";
            this.textBox13.Text = " ";
            this.textBox14.Text = " ";
            this.textBox15.Text = " ";
            this.textBox16.Text = " ";
            this.textBox17.Text = " ";
            this.textBox18.Text = " ";
            this.textBox19.Text = " ";
            this.textBox20.Text = " ";
            this.textBox21.Text = " ";

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE ID_CLIENTE = " + seek_c + "";

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
                            this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                            this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                            this.textBox4.Text = dr["SITUACAO"].ToString();
                            this.textBox5.Text = dr["DOCUMENTO"].ToString();
                            this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                            this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                            this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                            this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                            this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                            this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                            this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                            this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                            this.textBox14.Text = dr["CEP"].ToString();
                            this.textBox15.Text = dr["LOGRADOURO"].ToString();
                            this.textBox16.Text = dr["ENDERECO"].ToString();
                            this.textBox17.Text = dr["END_NUMERO"].ToString();
                            this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                            this.textBox19.Text = dr["BAIRRO"].ToString();
                            this.textBox20.Text = dr["CIDADE"].ToString();
                            this.textBox21.Text = dr["UF"].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {

                int seek_up = 0;
                seek_up = Convert.ToInt32(this.textBox1.Text);
                string ID_CLIENTE = this.textBox1.Text;
                string DATA_CADASTRO = this.textBox2.Text;
                string DATA_INATIVACAO = this.textBox3.Text;
                string ID_SITUACAO = "1";
                string DOCUMENTO = this.textBox5.Text;
                string RG_CLIENTE = this.textBox6.Text;
                string NOME_CLIENTE = this.textBox7.Text;
                string SOBRE_NOME_CLIENTE = this.textBox8.Text;
                string EMAIL_CLIENTE = this.textBox9.Text;
                string DDD_CLIENTE = this.textBox10.Text;
                string TEL_CLIENTE = this.textBox11.Text;
                string DDD_CEL_CLI = this.textBox12.Text;
                string CEL_CLIENTE = this.textBox13.Text;
                string CEP = this.textBox14.Text;
                string LOGRADOURO = this.textBox15.Text;
                string ENDERECO = this.textBox16.Text;

                int val_1;
                if (this.textBox17.Text == " ")
                {
                    val_1 = 0;
                }
                else
                {
                    val_1 = Convert.ToInt32(this.textBox17.Text);
                }

                int END_NUMERO = val_1;
                string COMPLEMENTO = this.textBox18.Text;
                string BAIRRO = this.textBox19.Text;
                string CIDADE = this.textBox20.Text;
                string UF = this.textBox21.Text;
                //string iEND_NOME = " ";
                //string iCOMPLEMENTO = " ";

                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = "";

                string strSQLupd = "UPDATE TB_CLIENTES SET   DATA_CADASTRO = '" + DATA_CADASTRO + "'," +
                                                                "DATA_INATIVACAO = '" + DATA_INATIVACAO + "'," +
                                                                "SITUACAO = " + ID_SITUACAO + "," +
                                                                "DOCUMENTO = '" + DOCUMENTO + "'," +
                                                                "RG_CLIENTE = '" + RG_CLIENTE + "'," +
                                                                "NOME_CLIENTE = '" + NOME_CLIENTE + "'," +
                                                                "SOBRE_NOME_CLIENTE = '" + SOBRE_NOME_CLIENTE + "'," +
                                                                "EMAIL_CLIENTE = '" + EMAIL_CLIENTE + "'," +
                                                                "DDD_CLIENTE = '" + DDD_CLIENTE + "'," +
                                                                "TEL_CLIENTE = '" + TEL_CLIENTE + "'," +
                                                                "DDD_CEL_CLI = '" + DDD_CEL_CLI + "'," +
                                                                "CEL_CLIENTE = '" + CEL_CLIENTE + "'," +
                                                                "CEP = '" + CEP + "'," +
                                                                "LOGRADOURO = '" + LOGRADOURO + "'," +
                                                                "ENDERECO = '" + ENDERECO + "'," +
                                                                "END_NUMERO = " + END_NUMERO + "," +
                                                                "COMPLEMENTO = '" + COMPLEMENTO + "'," +
                                                                "BAIRRO = '" + BAIRRO + "'," +
                                                                "CIDADE = '" + CIDADE + "'," +
                                                                "UF = '" + UF + "' WHERE ID_CLIENTE = " + seek_up + "";

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
            else
            {
                MessageBox.Show("ERRO: Não foi possivel Alterar !!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir o registro ?", "Exclusao?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int seek_up = 0;
                seek_up = Convert.ToInt32(this.textBox1.Text);

                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = "";

                string strSQLupd = "DELETE FROM TB_CLIENTES WHERE ID_CLIENTE = " + seek_up + "";

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
                            MessageBox.Show("Registro Excluido com Sucesso !!!");

                            this.textBox1.Text = " ";
                            this.textBox2.Text = " ";
                            this.textBox3.Text = " ";
                            this.textBox4.Text = " ";
                            this.textBox5.Text = " ";
                            this.textBox6.Text = " ";
                            this.textBox7.Text = " ";
                            this.textBox8.Text = " ";
                            this.textBox9.Text = " ";
                            this.textBox10.Text = " ";
                            this.textBox11.Text = " ";
                            this.textBox12.Text = " ";
                            this.textBox13.Text = " ";
                            this.textBox14.Text = " ";
                            this.textBox15.Text = " ";
                            this.textBox16.Text = " ";
                            this.textBox17.Text = " ";
                            this.textBox18.Text = " ";
                            this.textBox19.Text = " ";
                            this.textBox20.Text = " ";
                            this.textBox21.Text = " ";


                        }
                        catch
                        {
                            MessageBox.Show("ERRO: Não foi possivel Excluir !!!");
                        }
                        conexao.Close();
                    }
                    catch
                    {
                        MessageBox.Show("ERRO: Não foi possivel Excluir !!!");
                    }

                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("Exclusão Concelada !!!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker DateTimePicker1 = new DateTimePicker();

            //Set size and location.
            DateTimePicker1.Location = new Point(294,51);
            DateTimePicker1.Size = new Size(96, 20);

            // Set the alignment of the drop-down MonthCalendar to right.
            DateTimePicker1.DropDownAlign = LeftRightAlignment.Right;

            // Set the Value property to 50 years before today.
            DateTimePicker1.Value = System.DateTime.Now.AddYears(-50);

            //Set a custom format containing the string "of the year"
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.CustomFormat = "dd/mm/yyyy";

            // Add the DateTimePicker to the form.
            this.Controls.Add(DateTimePicker1);

        }


        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {

                string ID_CLIENTE = this.textBox1.Text;
                string DATA_CADASTRO = this.textBox2.Text;
                string DATA_INATIVACAO = this.textBox3.Text;
                string ID_SITUACAO = this.textBox4.Text;
                string DOCUMENTO = this.textBox5.Text;
                string RG_CLIENTE = this.textBox6.Text;
                string NOME_CLIENTE = this.textBox7.Text;
                string SOBRE_NOME_CLIENTE = this.textBox8.Text;
                string EMAIL_CLIENTE = this.textBox9.Text;
                string DDD_CLIENTE = this.textBox10.Text;
                string TEL_CLIENTE = this.textBox11.Text;
                string DDD_CEL_CLI = this.textBox12.Text;
                string CEL_CLIENTE = this.textBox13.Text;
                string CEP = this.textBox14.Text;
                string LOGRADOURO = this.textBox15.Text;
                string ENDERECO = this.textBox16.Text;
                int val_1;
                if (this.textBox17.Text == " ")
                {
                    val_1 = 0;
                }
                else
                {
                    val_1 = Convert.ToInt32(this.textBox17.Text);
                }

                int END_NUMERO = val_1;
                string COMPLEMENTO = this.textBox18.Text;
                string BAIRRO = this.textBox19.Text;
                string CIDADE = this.textBox20.Text;
                string UF = this.textBox21.Text;
                int ID_SIT = 1;
                int ID_CLI = Convert.ToInt32(this.textBox1.Text);

                this.textBox5.Focus();


                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;
                int seek_c = 0;
                seek_c = Convert.ToInt32(this.textBox1.Text);

                string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE NOME_CLIENTE = '" + this.textBox7.Text.ToString() + "'";

                SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao2.Open();
                    try
                    {

                        SqlCommand cmd2 = new SqlCommand(strSQL2, conexao2);
                        SqlDataReader dr2 = cmd2.ExecuteReader();

                        try
                        {
                            //MessageBox.Show("ERRO: Registro já Cadastrado !!!");
                        }
                        catch
                        {
                            //MessageBox.Show("ERRO: Registro já Cadastrado !!!");
                        }



                        if (dr2.Read())
                        {
                            MessageBox.Show("ERRO 01: Registro já Cadastrado !!!");
                        }
                        else
                        {

                            dr2.Close();
                            conexao2.Close();

                            string senha_user = NOME_CLIENTE.Substring(0, 3) + RG_CLIENTE.Substring(0, 3);
                            string user_ario = NOME_CLIENTE;
                            int situ_user = Convert.ToInt32(ID_SITUACAO);

                            /*
                            ID_CLIENTE
                            DATA_CADASTRO
                            DATA_INATIVACAO
                            ID_SITUACAO
                            DOCUMENTO
                            RG_CLIENTE
                            NOME_CLIENTE
                            SOBRE_NOME_CLIENTE
                            EMAIL_CLIENTE
                            DDD_CLIENTE
                            TEL_CLIENTE
                            DDD_CEL_CLI
                            CEL_CLIENTE
                            CEP
                            LOGRADOURO
                            ENDERECO
                            END_NUMERO
                            COMPLEMENTO
                            BAIRRO
                            CIDADE
                            UF
                */

                            //string host = "EDSON_CPD\\SQLEXPRESS2";
                            //string usuario = "sa";
                            //string senha = "12345";
                            //string banco = "DB_ALUGUEL";
                            //string id_busca = "";

                            string strSQLins = "INSERT INTO TB_CLIENTES (DATA_CADASTRO, " +
                                                                            "DATA_INATIVACAO, " +
                                                                            "SITUACAO, " +
                                                                            "DOCUMENTO, " +
                                                                            "RG_CLIENTE, " +
                                                                            "NOME_CLIENTE, " +
                                                                            "SOBRE_NOME_CLIENTE, " +
                                                                            "EMAIL_CLIENTE, " +
                                                                            "DDD_CLIENTE, " +
                                                                            "TEL_CLIENTE, " +
                                                                            "DDD_CEL_CLI, " +
                                                                            "CEL_CLIENTE, " +
                                                                            "CEP, " +
                                                                            "LOGRADOURO, " +
                                                                            "ENDERECO, " +
                                                                            "END_NUMERO, " +
                                                                            "COMPLEMENTO, " +
                                                                            "BAIRRO, " +
                                                                            "CIDADE, " +
                                                                            "UF) " +

                                                                     "VALUES   ('" + DATA_CADASTRO + "', " +
                                                                                "'" + DATA_INATIVACAO + "', " +
                                                                                "'" + ID_SITUACAO + "', " +
                                                                                "'" + DOCUMENTO + "', " +
                                                                                "'" + RG_CLIENTE + "', " +
                                                                                "'" + NOME_CLIENTE + "', " +
                                                                                "'" + SOBRE_NOME_CLIENTE + "', " +
                                                                                "'" + EMAIL_CLIENTE + "', " +
                                                                                "'" + DDD_CLIENTE + "', " +
                                                                                "'" + TEL_CLIENTE + "', " +
                                                                                "'" + DDD_CEL_CLI + "', " +
                                                                                "'" + CEL_CLIENTE + "', " +
                                                                                "'" + CEP + "', " +
                                                                                "'" + LOGRADOURO + "', " +
                                                                                "'" + ENDERECO + "', " +
                                                                                "" + END_NUMERO + ", " +
                                                                                "'" + COMPLEMENTO + "', " +
                                                                                "'" + BAIRRO + "', " +
                                                                                "'" + CIDADE + "', " +
                                                                                "'" + UF + "')";


                            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                            try
                            {
                                conexao.Open();
                                try
                                {

                                    SqlCommand cmd = new SqlCommand(strSQLins, conexao);
                                    cmd.ExecuteNonQuery();
                                    try
                                    {


                                        // inicio

                                        string strSQLins9 = "INSERT INTO TB_USUARIOS_CLIENTES (ID_USUARIO_CLIENTE, USUARIO, SENHA, SITUACAO) " +

                                             "VALUES   (" + ID_CLI + ", '" + user_ario + "', '" + senha_user + "', " + ID_SIT + ")";


                                        SqlConnection conexao9 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                                        try
                                        {
                                            conexao9.Open();
                                            try
                                            {

                                                SqlCommand cmd9 = new SqlCommand(strSQLins9, conexao9);
                                                cmd9.ExecuteNonQuery();
                                                try
                                                {
                                                    MessageBox.Show("Login de Usuario Criado com Sucesso !!!");

                                                }
                                                catch
                                                {
                                                    MessageBox.Show("ERRO 02: Não foi possivel Criar Login !!!");
                                                }
                                                conexao.Close();
                                            }
                                            catch
                                            {
                                                MessageBox.Show("ERRO 03: Não foi possivel Criar Login !!!");
                                            }

                                        }
                                        catch
                                        {

                                        }


                                        // fim


                                        MessageBox.Show("Usuario Incluido com Sucesso !!!");

                                    }
                                    catch
                                    {
                                        MessageBox.Show("ERRO 02: Não foi possivel Incluir !!!");
                                    }
                                    conexao.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("ERRO 03: Não foi possivel Incluir !!!");
                                }

                            }
                            catch
                            {

                            }

                        }
                    }
                    catch { MessageBox.Show("ERRO 03: Não foi possivel Incluir !!!"); }
                }
                catch { MessageBox.Show("ERRO 03: Não foi possivel Incluir !!!"); }
            }
            else
            {
                MessageBox.Show("ERRO 03: Não foi possivel Incluir !!!");
            }

            this.button11.Visible = false;
            this.button12.Visible = false;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox4.Enabled = true;

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button10.Enabled = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button11.Visible = false;
            this.button12.Visible = false;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox4.Enabled = true;

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button10.Enabled = true;

            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] ORDER BY ID_CLIENTE ASC";

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
                        this.textBox1.Text = dr["ID_CLIENTE"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_INATIVACAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["DOCUMENTO"].ToString();
                        this.textBox6.Text = dr["RG_CLIENTE"].ToString();
                        this.textBox7.Text = dr["NOME_CLIENTE"].ToString();
                        this.textBox8.Text = dr["SOBRE_NOME_CLIENTE"].ToString();
                        this.textBox9.Text = dr["EMAIL_CLIENTE"].ToString();
                        this.textBox10.Text = dr["DDD_CLIENTE"].ToString();
                        this.textBox11.Text = dr["TEL_CLIENTE"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_CLI"].ToString();
                        this.textBox13.Text = dr["CEL_CLIENTE"].ToString();
                        this.textBox14.Text = dr["CEP"].ToString();
                        this.textBox15.Text = dr["LOGRADOURO"].ToString();
                        this.textBox16.Text = dr["ENDERECO"].ToString();
                        this.textBox17.Text = dr["END_NUMERO"].ToString();
                        this.textBox18.Text = dr["COMPLEMENTO"].ToString();
                        this.textBox19.Text = dr["BAIRRO"].ToString();
                        this.textBox20.Text = dr["CIDADE"].ToString();
                        this.textBox21.Text = dr["UF"].ToString();

                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                { }
            }
            catch
            { }

        }


     
    }
}
