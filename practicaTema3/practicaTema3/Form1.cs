using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuario1_Click(object sender, EventArgs e)
        {
            lblMensaje1.Text = "Yo sigo haciendo mas commits";
        }

        private void btnUsuario2_Click(object sender, EventArgs e)
        {
            lblMensaje1.Text = "Usuario 2 haciendo commits";
            lblMensaje2.Text = "Usuario 2 haciendo commits";
        }
    }
}
