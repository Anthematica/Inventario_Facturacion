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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
        }

        public void AddForm(Form f)
        {
            
            
        } 

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            
            frmProductos frm = new frmProductos();
            frm.TopLevel = false;
            this.panel7.Tag = frm;
            this.panel7.Controls.Add(frm);
            frm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            frmClientes frm = new frmClientes();
            frm.TopLevel = false;
            this.panel7.Tag = frm;
            this.panel7.Controls.Add(frm);
            frm.Show();
            //frm.Dock = fill;

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;


            frmEmpleado frm = new frmEmpleado();
            frm.TopLevel = false;
            this.panel7.Tag = frm;
            this.panel7.Controls.Add(frm);
            frm.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;


            frmProveedor frm = new frmProveedor();
            frm.TopLevel = false;
            this.panel7.Tag = frm;
            this.panel7.Controls.Add(frm);
            frm.Show();
        }

        private void btnhHome_Click(object sender, EventArgs e)
        {
            
            /*this.panel7.Tag = pictureBox2;
            this.panel7.Controls.Add(pictureBox2);  ES PARA VOLVER AL MENU PRINCIPAL, ESTA MAL CONFIGURADO
            pictureBox2.Visible = true; */
        }
    }
}
