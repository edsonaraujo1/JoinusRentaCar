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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

            var var_1 = Usuario.Login;

            this.label21.Text = "Usuário: " + var_1;


            string host = "EDSON_CPD\\SQLEXPRESS2";  // EDSON_CPD\\SQLEXPRESS2
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] ORDER BY ID_VEICULO ASC";

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
                        this.textBox1.Text = dr["ID_VEICULO"].ToString();
                        this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                        this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                        // this.textBox4.Text = "";
                        this.textBox5.Text = dr["SITUACAO"].ToString();
                        this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                        this.textBox7.Text = dr["ANO_CARRO"].ToString();
                        this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                        this.textBox9.Text = "";
                        this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                        this.textBox11.Text = dr["PLACA"].ToString();

                    }
                    dr.Close();
                    conexao.Close();

                    // Pesquisa Fornecedor

                    int seek_ca = 0;
                    seek_ca = Convert.ToInt32(this.textBox2.Text);

                    string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                    SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                    try
                    {
                        conexao1.Open();
                        try
                        {

                            SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                            SqlDataReader dr2 = cmd2.ExecuteReader();
                            try
                            {


                                while (dr2.Read())
                                {
                                    this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                }

                                dr2.Close();
                                conexao1.Close();
                            }
                            catch { }
                        }
                        catch { }
                    }
                    catch { }

                    // Pesquisa Cor

                    int seek_cv = 0;
                    seek_cv = Convert.ToInt32(this.textBox8.Text);

                    string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                    SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                    try
                    {
                        conexao2.Open();
                        try
                        {

                            SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                            SqlDataReader dr3 = cmd3.ExecuteReader();
                            try
                            {


                                while (dr3.Read())
                                {
                                    this.textBox9.Text = dr3["DESC_COR"].ToString();

                                }

                                dr3.Close();
                                conexao2.Close();
                            }
                            catch { }
                        }
                        catch { }
                    }
                    catch { }

                    // FIM consulta

                }
                catch
                {

                }

            }
            catch
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {

                string ID_VEICULO = this.textBox1.Text;
                int ID_FORNECEDOR = Convert.ToInt32(this.textBox2.Text);
                string DATA_CADASTRO = this.textBox3.Text;
                this.textBox4.Text = "";
                int ID_SITUACAO = Convert.ToInt32(this.textBox5.Text);
                string MODELO_VEIC = this.textBox6.Text;
                string ANO_CARRO = this.textBox7.Text;
                int ID_COR_VEICULO = Convert.ToInt32(this.textBox8.Text);
                this.textBox9.Text = "";
                double VALOR_ALUGUEL = Convert.ToDouble(this.textBox10.Text);
                string PLACA = this.textBox11.Text;

                int val_1;
                if (this.textBox1.Text == " ")
                {
                    val_1 = 0;
                }
                else
                {
                    val_1 = Convert.ToInt32(this.textBox1.Text);
                }

                int END_NUMERO = val_1;
                int ID_CLI = Convert.ToInt32(this.textBox1.Text);

                this.textBox2.Focus();


                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;
                int seek_c = 0;
                seek_c = Convert.ToInt32(this.textBox1.Text);

                string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] WHERE ID_VEICULO = " + ID_CLI + "";

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

                            string strSQLins = "INSERT INTO TB_VEICULOS (ID_FORNECEDOR, " +
                                                                            "DATA_CADASTRO, " +
                                                                            "SITUACAO, " +
                                                                            "MODELO_VEIC, " +
                                                                            "ANO_CARRO, " +
                                                                            "ID_COR_VEICULO, " +
                                                                            "VALOR_ALUGUEL, " +
                                                                            "PLACA) " +

                                                                     "VALUES   (" + ID_FORNECEDOR + ", " +
                                                                                "'" + DATA_CADASTRO + "', " +
                                                                                "" + ID_SITUACAO + ", " +
                                                                                "'" + MODELO_VEIC + "', " +
                                                                                "'" + ANO_CARRO + "', " +
                                                                                "" + ID_COR_VEICULO + ", " +
                                                                                "'" + VALOR_ALUGUEL + "', " +
                                                                                "'" + PLACA + "')";


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

                                        // fim


                                        MessageBox.Show("Veiculo Incluido com Sucesso !!!");

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
            this.textBox3.Enabled = true;
            this.textBox2.Enabled = true;

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

            this.textBox3.Text = DateTime.Now.ToString("d");
            this.button11.Visible = true;
            this.button12.Visible = true;
            this.textBox1.Enabled = false;
            this.textBox3.Enabled = false;
            this.textBox2.Focus();
            this.textBox1.Text = "1";

            string host = "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] ORDER BY ID_VEICULO DESC";

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
                        string codigo = dr["ID_VEICULO"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {

                int seek_up = 0;
                seek_up = Convert.ToInt32(this.textBox1.Text);
                int ID_FORNECEDOR = Convert.ToInt32(this.textBox2.Text);
                string DATA_CADASTRO = this.textBox3.Text;
                this.textBox4.Text = "";
                int ID_SITUACAO = 1;
                string MODELO_VEIC = this.textBox6.Text;
                string ANO_CARRO = this.textBox7.Text;
                int ID_COR_VEICULO = Convert.ToInt32(this.textBox8.Text);
                this.textBox9.Text = "";
                double VALOR_ALUGUEL = Convert.ToDouble(this.textBox10.Text);
                string PLACA = this.textBox11.Text;


                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = "";

                string strSQLupd = "UPDATE TB_VEICULOS SET   ID_FORNECEDOR = " + ID_FORNECEDOR + "," +
                                                             "DATA_CADASTRO = '" + DATA_CADASTRO + "'," +
                                                             "SITUACAO = " + ID_SITUACAO + "," +
                                                             "MODELO_VEIC = '" + MODELO_VEIC + "'," +
                                                             "ANO_CARRO = '" + ANO_CARRO + "'," +
                                                             "ID_COR_VEICULO = " + ID_COR_VEICULO + "," +
                                                             "VALOR_ALUGUEL = " + VALOR_ALUGUEL + "," +
                                                             "PLACA = '" + PLACA + "' WHERE ID_VEICULO = " + seek_up + "";

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

                string strSQLupd = "DELETE FROM TB_VEICULOS WHERE ID_VEICULO = " + seek_up + "";

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] WHERE ID_VEICULO = " + seek_c + "";

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
                            this.textBox1.Text = dr["ID_VEICULO"].ToString();
                            this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                            this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox4.Text = "";
                            this.textBox5.Text = dr["SITUACAO"].ToString();
                            this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                            this.textBox7.Text = dr["ANO_CARRO"].ToString();
                            this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                            this.textBox9.Text = "";
                            this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                            this.textBox11.Text = dr["PLACA"].ToString();

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



                        // Pesquisa Fornecedor

                        int seek_ca = 0;
                        seek_ca = Convert.ToInt32(this.textBox2.Text);

                        string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                        SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao1.Open();
                            try
                            {

                                SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                try
                                {


                                    while (dr2.Read())
                                    {
                                        this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                    }

                                    dr2.Close();
                                    conexao1.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }

                        // Pesquisa Cor

                        int seek_cv = 0;
                        seek_cv = Convert.ToInt32(this.textBox8.Text);

                        string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                        SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao2.Open();
                            try
                            {

                                SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                                SqlDataReader dr3 = cmd3.ExecuteReader();
                                try
                                {


                                    while (dr3.Read())
                                    {
                                        this.textBox9.Text = dr3["DESC_COR"].ToString();

                                    }

                                    dr3.Close();
                                    conexao2.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }
                        // Fim Consulta


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

        private void button6_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] ORDER BY ID_VEICULO DESC";

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
                            this.textBox1.Text = dr["ID_VEICULO"].ToString();
                            this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                            this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox4.Text = "";
                            this.textBox5.Text = dr["SITUACAO"].ToString();
                            this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                            this.textBox7.Text = dr["ANO_CARRO"].ToString();
                            this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                            this.textBox9.Text = "";
                            this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                            this.textBox11.Text = dr["PLACA"].ToString();

                        }

                         dr.Close();
                        conexao.Close();


                        // Pesquisa Fornecedor

                        int seek_ca = 0;
                        seek_ca = Convert.ToInt32(this.textBox2.Text);

                        string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                        SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao1.Open();
                            try
                            {

                                SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                try
                                {


                                    while (dr2.Read())
                                    {
                                        this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                    }

                                    dr2.Close();
                                    conexao1.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }

                        // Pesquisa Cor

                        int seek_cv = 0;
                        seek_cv = Convert.ToInt32(this.textBox8.Text);

                        string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                        SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao2.Open();
                            try
                            {

                                SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                                SqlDataReader dr3 = cmd3.ExecuteReader();
                                try
                                {


                                    while (dr3.Read())
                                    {
                                        this.textBox9.Text = dr3["DESC_COR"].ToString();

                                    }

                                    dr3.Close();
                                    conexao2.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }
                        // Fim Consulta


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

        private void button9_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] ORDER BY ID_VEICULO ASC";

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
                            this.textBox1.Text = dr["ID_VEICULO"].ToString();
                            this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                            this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox4.Text = "";
                            this.textBox5.Text = dr["SITUACAO"].ToString();
                            this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                            this.textBox7.Text = dr["ANO_CARRO"].ToString();
                            this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                            this.textBox9.Text = "";
                            this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                            this.textBox11.Text = dr["PLACA"].ToString();

                        }

                        dr.Close();
                        conexao.Close();


                        // Pesquisa Fornecedor

                        int seek_ca = 0;
                        seek_ca = Convert.ToInt32(this.textBox2.Text);

                        string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                        SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao1.Open();
                            try
                            {

                                SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                try
                                {


                                    while (dr2.Read())
                                    {
                                        this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                    }

                                    dr2.Close();
                                    conexao1.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }

                        // Pesquisa Cor

                        int seek_cv = 0;
                        seek_cv = Convert.ToInt32(this.textBox8.Text);

                        string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                        SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao2.Open();
                            try
                            {

                                SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                                SqlDataReader dr3 = cmd3.ExecuteReader();
                                try
                                {


                                    while (dr3.Read())
                                    {
                                        this.textBox9.Text = dr3["DESC_COR"].ToString();

                                    }

                                    dr3.Close();
                                    conexao2.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }
// Fim Consulta

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

        private void button8_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] WHERE ID_VEICULO = " + seek + "";

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
                            this.textBox1.Text = dr["ID_VEICULO"].ToString();
                            this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                            this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox4.Text = "";
                            this.textBox5.Text = dr["SITUACAO"].ToString();
                            this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                            this.textBox7.Text = dr["ANO_CARRO"].ToString();
                            this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                            this.textBox9.Text = "";
                            this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                            this.textBox11.Text = dr["PLACA"].ToString();

                        }

                        dr.Close();
                        conexao.Close();


                        // Pesquisa Fornecedor

                        int seek_ca = 0;
                        seek_ca = Convert.ToInt32(this.textBox2.Text);

                        string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                        SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao1.Open();
                            try
                            {

                                SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                try
                                {


                                    while (dr2.Read())
                                    {
                                        this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                    }

                                    dr2.Close();
                                    conexao1.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }

                        // Pesquisa Cor

                        int seek_cv = 0;
                        seek_cv = Convert.ToInt32(this.textBox8.Text);

                        string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                        SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao2.Open();
                            try
                            {

                                SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                                SqlDataReader dr3 = cmd3.ExecuteReader();
                                try
                                {


                                    while (dr3.Read())
                                    {
                                        this.textBox9.Text = dr3["DESC_COR"].ToString();

                                    }

                                    dr3.Close();
                                    conexao2.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }
                        // Fim Consulta

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

        private void button7_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] WHERE ID_VEICULO = " + seek + "";

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
                            this.textBox1.Text = dr["ID_VEICULO"].ToString();
                            this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                            this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                            this.textBox4.Text = "";
                            this.textBox5.Text = dr["SITUACAO"].ToString();
                            this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                            this.textBox7.Text = dr["ANO_CARRO"].ToString();
                            this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                            this.textBox9.Text = "";
                            this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                            this.textBox11.Text = dr["PLACA"].ToString();

                        }

                         dr.Close();
                        conexao.Close();



                        // Pesquisa Fornecedor

                        int seek_ca = 0;
                        seek_ca = Convert.ToInt32(this.textBox2.Text);

                        string strSQL1 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_ca + "";

                        SqlConnection conexao1 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao1.Open();
                            try
                            {

                                SqlCommand cmd2 = new SqlCommand(strSQL1, conexao1);
                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                try
                                {


                                    while (dr2.Read())
                                    {
                                        this.textBox4.Text = dr2["NOME_FORNECEDOR"].ToString();

                                    }

                                    dr2.Close();
                                    conexao1.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }

                        // Pesquisa Cor

                        int seek_cv = 0;
                        seek_cv = Convert.ToInt32(this.textBox8.Text);

                        string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_cv + "";

                        SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                        try
                        {
                            conexao2.Open();
                            try
                            {

                                SqlCommand cmd3 = new SqlCommand(strSQL2, conexao2);
                                SqlDataReader dr3 = cmd3.ExecuteReader();
                                try
                                {


                                    while (dr3.Read())
                                    {
                                        this.textBox9.Text = dr3["DESC_COR"].ToString();

                                    }

                                    dr3.Close();
                                    conexao2.Close();
                                }
                                catch { }
                            }
                            catch { }
                        }
                        catch { }
                        // Fim Consulta

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

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] ORDER BY ID_VEICULO ASC";

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
                        this.textBox1.Text = dr["ID_VEICULO"].ToString();
                        this.textBox2.Text = dr["ID_FORNECEDOR"].ToString();
                        this.textBox3.Text = dr["DATA_CADASTRO"].ToString();
                        this.textBox4.Text = "";
                        this.textBox5.Text = dr["SITUACAO"].ToString();
                        this.textBox6.Text = dr["MODELO_VEIC"].ToString();
                        this.textBox7.Text = dr["ANO_CARRO"].ToString();
                        this.textBox8.Text = dr["ID_COR_VEICULO"].ToString();
                        this.textBox9.Text = "";
                        this.textBox10.Text = dr["VALOR_ALUGUEL"].ToString();
                        this.textBox11.Text = dr["PLACA"].ToString();
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


        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            int seek_c = 0;
            seek_c = Convert.ToInt32(this.textBox2.Text);

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_FORNECEDORES] WHERE ID_FORNECEDOR = " + seek_c + "";

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
                            this.textBox4.Text = dr["NOME_FORNECEDOR"].ToString();

                        }

                        if (dr.HasRows)
                        {
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não Encontrado !!!");
                        }
                        dr.Close();
                        conexao.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Fornecedor não Encontrado !!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Fornecedor não Encontrado !!!");
                }

            }
            catch
            {
                MessageBox.Show("Fornecedor não Encontrado !!!");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {

            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            //string id_busca = " ";
            //string id_busca = 0;
            int seek_c = 0;
            seek_c = Convert.ToInt32(this.textBox8.Text);

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_COR] WHERE ID_COR_VEICULO = " + seek_c + "";

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
                            this.textBox9.Text = dr["DESC_COR"].ToString();

                        }

                        if (dr.HasRows)
                        {
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cor não Encontrado !!!");
                        }
                        dr.Close();
                        conexao.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Cor não Encontrado !!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Cor não Encontrado !!!");
                }

            }
            catch
            {
                MessageBox.Show("Cor não Encontrado !!!");
            }



        }


    }
}
