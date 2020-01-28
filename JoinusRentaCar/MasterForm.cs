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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            this.label1.Text = "Seja bem Vindo!!! " + WindowsFormsApplication1.MasterForm.Variaveis.Usuario;
        }
        public static class Variaveis
        {

            public static string Usuario;

        }

    }
}
