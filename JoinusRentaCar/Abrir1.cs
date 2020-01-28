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
    public partial class Abrir1 : Form
    {
        public Abrir1()
        {
            InitializeComponent();
        }

        MDIParent1 formulario { get; set; }

        public Abrir1(MDIParent1 formulario)
        {
            this.formulario = formulario;
            this.formulario.HabilitarMenu(true);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
