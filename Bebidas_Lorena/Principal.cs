using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bebidas_Lorena
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FormFacturaVenta frm = new FormFacturaVenta();
            frm.TopLevel = false;
            this.panel5.Tag = frm;
            this.panel5.Controls.Add(frm);
            frm.Show();
        }
    }
}
