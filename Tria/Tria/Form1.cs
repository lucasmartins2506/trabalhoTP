using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tria
{
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbEqui_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbEqui.Checked == true)
            {
                txtLado1.Visible = true;
                txtLado2.Visible = false;
                txtLado3.Visible = false;

                lblLado1.Visible = true;
                lblLado2.Visible = false;
                lblLado3.Visible = false;

                txtLado2.Clear();
                txtLado3.Clear();
            }
        }

        private void rdbIso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIso.Checked == true)
            {
                txtLado1.Visible = true;
                txtLado2.Visible = true;
                txtLado3.Visible = false;

                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = false;

                txtLado3.Clear();
            }
        }

        private void rdbEsca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEsca.Checked == true)
            {
                txtLado1.Visible = true;
                txtLado2.Visible = true;
                txtLado3.Visible = true;

                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;

            }
        }
    }
}
