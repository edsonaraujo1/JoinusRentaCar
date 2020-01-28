using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }
        public static int IsLogin = 0;
        public static int IsPremis = 0;

        public static string User;
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_FUNCIONARIOS] WHERE USUARIO = '" + this.textBox1.Text + "' AND SENHA = '" + this.textBox2.Text + "'";

            //SELECT * FROM TB_USUARIOS_FUNCIONARIOS WHERE USUARIO = '" + this.textBox1.Text + "' AND SENHA = '" + this.textBox2.Text + "'";

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


                        if (dr.Read())
                        {

                            //verifica se o login e senha e atribuir o
                            //nome do usuário e perfil ás variáveis globais
                            Usuario.Login = this.textBox1.Text;
                            IsLogin = 1;
                            IsPremis = 1; // Permissao
                            
                            this.Close();

                        }

                        if (dr.HasRows)
                        {
                            dr.Close();
                        }
                        else
                        {
                            IsLogin = 0;
                            MessageBox.Show("Usuário ou Senha Invalidos !!!");
                            this.textBox1.Text = "";
                            this.textBox2.Text = "";
                            this.textBox1.Focus();
                            //Application.Exit();
                        }
                        dr.Close();
                        conexao.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Usuário ou Senha Invalidos !!!");
                        this.textBox1.Text = "";
                        this.textBox2.Text = "";
                        this.textBox1.Focus();
                        //Application.Exit();
                    }
                }
                catch
                {
                    

                    MessageBox.Show("Usuário ou Senha Invalidos !!!");
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox1.Focus();
                    //Application.Exit();
                }

            }
            catch
            {
                MessageBox.Show("Usuário ou Senha Invalidos !!!");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Focus();
                //Application.Exit();
            }


        }
    }
}
