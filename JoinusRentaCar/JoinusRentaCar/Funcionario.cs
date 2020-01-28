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
    public partial class Funcionario : Form
    {
        //public string var_1 = Usuario.Login;
        
        public Funcionario()
        {

            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

                var var_1 = Usuario.Login;

                this.label21.Text = "Usuário: " + var_1;


                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;

                string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] ORDER BY ID_FUNCIONARIO ASC";

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
                            this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                            this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                            this.textBox4.Text = dr["SITUACAO"].ToString();
                            this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                            this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                            this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                            this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                            this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                            this.textBox10.Text = dr["DDD_FUNC"].ToString();
                            this.textBox11.Text = dr["TEL_FUNC"].ToString();
                            this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                            this.textBox13.Text = dr["CEL_FUNC"].ToString();
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] ORDER BY ID_FUNCIONARIO DESC";

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
                        string codigo = dr["ID_FUNCIONARIO"].ToString();
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] ORDER BY ID_FUNCIONARIO ASC";

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
                        this.textBox3.Text = dr["SITUACAO"].ToString();
                        this.textBox4.Text = dr["DATA_INATIVACAO"].ToString();
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
                        this.textBox18.Text = dr["BAIRRO"].ToString();
                        this.textBox19.Text = dr["CIDADE"].ToString();
                        this.textBox20.Text = dr["UF"].ToString();

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] ORDER BY ID_FUNCIONARIO DESC";

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
                        this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                        this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                        this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                        this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                        this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                        this.textBox10.Text = dr["DDD_FUNC"].ToString();
                        this.textBox11.Text = dr["TEL_FUNC"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                        this.textBox13.Text = dr["CEL_FUNC"].ToString();
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] WHERE ID_FUNCIONARIO = " + seek + "";

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
                        this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                        this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                        this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                        this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                        this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                        this.textBox10.Text = dr["DDD_FUNC"].ToString();
                        this.textBox11.Text = dr["TEL_FUNC"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                        this.textBox13.Text = dr["CEL_FUNC"].ToString();
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] WHERE ID_FUNCIONARIO = " + seek + "";

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
                        this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                        this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                        this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                        this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                        this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                        this.textBox10.Text = dr["DDD_FUNC"].ToString();
                        this.textBox11.Text = dr["TEL_FUNC"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                        this.textBox13.Text = dr["CEL_FUNC"].ToString();
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] WHERE ID_FUNCIONARIO = " + seek_c + "";

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
                            this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                            this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                            this.textBox4.Text = dr["SITUACAO"].ToString();
                            this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                            this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                            this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                            this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                            this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                            this.textBox10.Text = dr["DDD_FUNC"].ToString();
                            this.textBox11.Text = dr["TEL_FUNC"].ToString();
                            this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                            this.textBox13.Text = dr["CEL_FUNC"].ToString();
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
                string ID_FUNCIONARIO = this.textBox1.Text;
                string DATA_CADASTRO = this.textBox2.Text;
                string DATA_DEMISSAO = this.textBox3.Text;
                string ID_SITUACAO = "1";
                string CPF_FUNCIONARIO = this.textBox5.Text;
                string RG_FUNCIONARIO = this.textBox6.Text;
                string NOME_FUNCIONARIO = this.textBox7.Text;
                string SOBRENOME_FUNCIONARIO = this.textBox8.Text;
                string EMAIL_FUNC = this.textBox9.Text;
                string DDD_FUNC = this.textBox10.Text;
                string TEL_FUNC = this.textBox11.Text;
                string DDD_CEL_FUNC = this.textBox12.Text;
                string CEL_FUNC = this.textBox13.Text;
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

                string strSQLupd = "UPDATE TB_FUNCIONARIOS SET   DATA_CADASTRO = '" + DATA_CADASTRO + "'," +
                                                                "DATA_DEMISSAO = '" + DATA_DEMISSAO + "'," +
                                                                "SITUACAO = " + ID_SITUACAO + "," +
                                                                "CPF_FUNCIONARIO = '" + CPF_FUNCIONARIO + "'," +
                                                                "RG_FUNCIONARIO = '" + RG_FUNCIONARIO + "'," +
                                                                "NOME_FUNCIONARIO = '" + NOME_FUNCIONARIO + "'," +
                                                                "SOBRENOME_FUNCIONARIO = '" + SOBRENOME_FUNCIONARIO + "'," +
                                                                "EMAIL_FUNC = '" + EMAIL_FUNC + "'," +
                                                                "DDD_FUNC = '" + DDD_FUNC + "'," +
                                                                "TEL_FUNC = '" + TEL_FUNC + "'," +
                                                                "DDD_CEL_FUNC = '" + DDD_CEL_FUNC + "'," +
                                                                "CEL_FUNC = '" + CEL_FUNC + "'," +
                                                                "CEP = '" + CEP + "'," +
                                                                "LOGRADOURO = '" + LOGRADOURO + "'," +
                                                                "ENDERECO = '" + ENDERECO + "'," +
                                                                "END_NUMERO = " + END_NUMERO + "," +
                                                                "COMPLEMENTO = '" + COMPLEMENTO + "'," +
                                                                "BAIRRO = '" + BAIRRO + "'," +
                                                                "CIDADE = '" + CIDADE + "'," +
                                                                "UF = '" + UF + "' WHERE ID_FUNCIONARIO = " + seek_up + "";

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

            if (MessageBox.Show("Deseja Inativar o registro ?", "Exclusao?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int seek_up = 0;
                seek_up = Convert.ToInt32(this.textBox1.Text);

                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = "";

                string strSQLupd = "DELETE FROM TB_FUNCIONARIOS WHERE ID_FUNCIONARIO = " + seek_up + "";

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


        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                errValidacao.SetError(tb, "Error");
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text != " ")
            {
                string ID_FUNCIONARIO = this.textBox1.Text;
                string DATA_CADASTRO = this.textBox2.Text;
                string DATA_DEMISSAO = this.textBox3.Text;
                int ID_SITUACAO = Convert.ToInt32(this.textBox4.Text);
                string CPF_FUNCIONARIO = this.textBox5.Text;
                string RG_FUNCIONARIO = this.textBox6.Text;
                string NOME_FUNCIONARIO = this.textBox7.Text;
                string SOBRENOME_FUNCIONARIO = this.textBox8.Text;
                string EMAIL_FUNC = this.textBox9.Text;
                string DDD_FUNC = this.textBox10.Text;
                string TEL_FUNC = this.textBox11.Text;
                string DDD_CEL_FUNC = this.textBox12.Text;
                string CEL_FUNC = this.textBox13.Text;
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
                int va_2;
                int ID_SIT = 1;
                if (this.textBox1.Text == " ")
                {
                    va_2 = 0;
                }
                else
                {
                    va_2 = Convert.ToInt32(this.textBox1.Text);

                }
                int ID_CLI = va_2;
                string PERMISSAO = "1";
                this.textBox5.Focus();


                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;
                int seek_c = 0;
                seek_c = Convert.ToInt32(this.textBox1.Text);

                string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] WHERE CPF_FUNCIONARIO = '" + this.textBox5.Text.ToString() + "'";

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

                            string senha_user = NOME_FUNCIONARIO.Substring(0, 3) + RG_FUNCIONARIO.Substring(0, 3);
                            string user_ario = NOME_FUNCIONARIO;
                            int situ_user = Convert.ToInt32(ID_SITUACAO);


                            /*
                            ID_FUNCIONARIO
                            DATA_CADASTRO
                            DATA_DEMISSAO
                            ID_SITUACAO
                            CPF_FUNCIONARIO
                            RG_FUNCIONARIO
                            NOME_FUNCIONARIO
                            SOBRENOME_FUNCIONARIO
                            EMAIL_FUNC
                            DDD_FUNC
                            TEL_FUNC
                            DDD_CEL_FUNC
                            CEL_FUNC
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

                            string strSQLins = "INSERT INTO TB_FUNCIONARIOS (DATA_CADASTRO, " +
                                                                            "DATA_DEMISSAO, " +
                                                                            "SITUACAO, " +
                                                                            "CPF_FUNCIONARIO, " +
                                                                            "RG_FUNCIONARIO, " +
                                                                            "NOME_FUNCIONARIO, " +
                                                                            "SOBRENOME_FUNCIONARIO, " +
                                                                            "EMAIL_FUNC, " +
                                                                            "DDD_FUNC, " +
                                                                            "TEL_FUNC, " +
                                                                            "DDD_CEL_FUNC, " +
                                                                            "CEL_FUNC, " +
                                                                            "CEP, " +
                                                                            "LOGRADOURO, " +
                                                                            "ENDERECO, " +
                                                                            "END_NUMERO, " +
                                                                            "COMPLEMENTO, " +
                                                                            "BAIRRO, " +
                                                                            "CIDADE, " +
                                                                            "UF) " +

                                                                     "VALUES   ('" + DATA_CADASTRO + "', " +
                                                                                "'" + DATA_DEMISSAO + "', " +
                                                                                "'" + ID_SITUACAO + "', " +
                                                                                "'" + CPF_FUNCIONARIO + "', " +
                                                                                "'" + RG_FUNCIONARIO + "', " +
                                                                                "'" + NOME_FUNCIONARIO + "', " +
                                                                                "'" + SOBRENOME_FUNCIONARIO + "', " +
                                                                                "'" + EMAIL_FUNC + "', " +
                                                                                "'" + DDD_FUNC + "', " +
                                                                                "'" + TEL_FUNC + "', " +
                                                                                "'" + DDD_CEL_FUNC + "', " +
                                                                                "'" + CEL_FUNC + "', " +
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

                                        string strSQLins9 = "INSERT INTO TB_USUARIOS_FUNCIONARIOS (ID_USUARIO_FUNC, USUARIO, SENHA, SITUACAO) " +

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



                                        MessageBox.Show("Incluido com Sucesso !!!");

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
                    catch { }
                }
                catch { }
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FUNCIONARIOS] ORDER BY ID_FUNCIONARIO ASC";

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
                        this.textBox1.Text = dr["ID_FUNCIONARIO"].ToString();
                        this.textBox2.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox3.Text = dr["DATA_DEMISSAO"].ToString();
                        this.textBox4.Text = dr["SITUACAO"].ToString();
                        this.textBox5.Text = dr["CPF_FUNCIONARIO"].ToString();
                        this.textBox6.Text = dr["RG_FUNCIONARIO"].ToString();
                        this.textBox7.Text = dr["NOME_FUNCIONARIO"].ToString();
                        this.textBox8.Text = dr["SOBRENOME_FUNCIONARIO"].ToString();
                        this.textBox9.Text = dr["EMAIL_FUNC"].ToString();
                        this.textBox10.Text = dr["DDD_FUNC"].ToString();
                        this.textBox11.Text = dr["TEL_FUNC"].ToString();
                        this.textBox12.Text = dr["DDD_CEL_FUNC"].ToString();
                        this.textBox13.Text = dr["CEL_FUNC"].ToString();
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
