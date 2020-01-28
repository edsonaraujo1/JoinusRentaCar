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
    public partial class MDIParent1 : Form
    {

        private int childFormNumber = 0;
       
        public MDIParent1()
        {
            
            InitializeComponent();
        }

         public void HabilitarMenu(bool habilitar)
        {
            menuStrip.Enabled = habilitar;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
            //this.label1.Text = "Seja bem Vindo!!!";
            childForm.Enabled = false;

            

         }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Aluguel alugue = new Aluguel();
                    alugue.MdiParent = this;
                    alugue.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }


        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Clientes cliente = new Clientes();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Funcionario Funcionario = new Funcionario();
                    Funcionario.MdiParent = this;
                    Funcionario.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }


        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Informacao About1 = new Informacao();
                    About1.MdiParent = this;
                    About1.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Veiculos veiculos = new Veiculos();
                    veiculos.MdiParent = this;
                    veiculos.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Recibo reci = new Recibo();
                    reci.MdiParent = this;
                    reci.Show();
                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

            //this.menuStrip.Enabled = false;
            Login entrar = new Login();
            entrar.MdiParent = this;
            entrar.Show();


        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void criarSenhaUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Senha1 senha0 = new Senha1();
                    senha0.MdiParent = this;
                    senha0.Show();

                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }

        }

        private void criarSenhaFuncioanriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.IsLogin == 1)
            {
                if (Login.IsPremis == 1)
                {

                    Senha2 senha0A = new Senha2();
                    senha0A.MdiParent = this;
                    senha0A.Show();

                }
                else
                {

                    MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                }

            }


        }
    }
}