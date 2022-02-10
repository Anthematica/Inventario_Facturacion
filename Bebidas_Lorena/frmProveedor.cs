using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Datos;

namespace Bebidas_Lorena
{
    public partial class frmProveedor : Form
    {
        int idproveedor;
        //          funciones para mostrar, ingresar, editar, eliminar, buscar y limpiar
        private void mostrar()
        {
            DataTable dt;
            dProveedor funcion = new dProveedor();
            dt = funcion.mostrar();
            dgvMostrar.DataSource = dt;
        }

        private void buscar()
        {
            DataTable dt;
            dProveedor funcion = new dProveedor();
            dt = funcion.buscar(txtBuscar.Text);
            dgvMostrar.DataSource = dt;
        }
        private void insertar()
        {
            eProveedor dt = new eProveedor();
            dProveedor funcion = new dProveedor();

            dt.NombreEmpresa = txtNombreEmpresa.Text;
            dt.NombreProveedor = txtNombreProveedor.Text;
            dt.Direccion = txtDireccionEmpresa.Text;
            dt.Telefono = txtTelefonoProveedor.Text;
            dt.Estado = 1;

            if (funcion.insertar(dt))
            {
                MessageBox.Show("Proveedor registrado", "Registro correcto", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }

        private void editar()
        {
            eProveedor dt = new eProveedor();
            dProveedor funcion = new dProveedor();
            dt.IdProveedor = idproveedor;
            dt.NombreEmpresa = txtNombreEmpresa.Text;
            dt.NombreProveedor = txtNombreProveedor.Text;
            dt.Direccion = txtDireccionEmpresa.Text;
            dt.Telefono = txtTelefonoProveedor.Text;
            dt.Estado = 1;
            if (funcion.editar(dt))
            {
                MessageBox.Show("proveedor modificado", "Edicion correcta", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }
        private void eliminar()
        {
            eProveedor dt = new eProveedor();
            dProveedor funcion = new dProveedor();
            dt.IdProveedor = idproveedor;
            if (funcion.eliminar(dt))
            {
                MessageBox.Show("Proveedor eliminado", "Eliminacion correcta", MessageBoxButtons.OKCancel);
                panelAgregarDatos.Visible = false;
            }
        }

        private void limpiar()
        {
            txtDireccionEmpresa.Clear();
            txtNombreEmpresa.Clear();
            txtNombreProveedor.Clear();
            txtTelefonoProveedor.Clear();
        }

        //      TERMINAN LAS FUNCIONES DE LAS OPERACIONES PRINCIPALES
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregarDatos.Visible = true;
            btnGuardarCambios.Visible = false;
            btnGuardar.Visible = true;
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text != "" || txtNombreProveedor.Text != "" || txtDireccionEmpresa.Text != "" || txtTelefonoProveedor.Text != "")
            {
                //MessageBox.Show("Faltan informacion por completar", "Datos", MessageBoxButtons.OK);
                insertar();
                mostrar();
            }
            else
            {
                //insertar();
                //mostrar();
                MessageBox.Show("Faltan informacion por completar", "Datos", MessageBoxButtons.OK);
            }
            limpiar();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            editar();
            mostrar();
            limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelAgregarDatos.Visible = false;
            limpiar();
        }

        private void dgvMostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idproveedor = Convert.ToInt32(dgvMostrar.SelectedCells[2].Value.ToString());

            if (e.ColumnIndex == this.dgvMostrar.Columns["Editar"].Index)
            {
                txtNombreEmpresa.Text = dgvMostrar.SelectedCells[3].Value.ToString();
                txtNombreProveedor.Text = dgvMostrar.SelectedCells[4].Value.ToString();
                txtTelefonoProveedor.Text = dgvMostrar.SelectedCells[5].Value.ToString();
                txtDireccionEmpresa.Text = dgvMostrar.SelectedCells[6].Value.ToString();
                panelAgregarDatos.Visible = true;
                btnGuardar.Visible = false;
                btnGuardarCambios.Visible = true;
            }
            if (e.ColumnIndex == this.dgvMostrar.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar este resgistro?", "Eliminacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminar();
                }
                //eliminar();
                mostrar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
