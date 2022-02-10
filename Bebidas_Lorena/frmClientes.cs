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
    public partial class frmClientes : Form
    {
        int idcliente;

        //          funciones para mostrar, ingresar, editar, eliminar, buscar y limpiar
        private void mostrar()
        {
            DataTable dt;
            dClientes funcion = new dClientes();
            dt = funcion.mostrar();
            dgvMostrar.DataSource = dt;
        }

        private void buscar()
        {
            DataTable dt;
            dClientes funcion = new dClientes();
            dt = funcion.buscar(txtBuscar.Text);
            dgvMostrar.DataSource = dt;
        }
        private void insertar()
        {
            eClientes dt = new eClientes();
            dClientes funcion = new dClientes();

            dt.Nombre = txtNombre.Text;
            dt.Apellido = txtApellido.Text;
            dt.Telefono = txtTelefono.Text;
            dt.Direccion = txtDireccion.Text;
            dt.Estado = 1;

            if (funcion.insertar(dt))
            {
                MessageBox.Show("Cliente registrado", "Registro correcto", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }

        private void editar()
        {
            eClientes dt = new eClientes();
            dClientes funcion = new dClientes();
            dt.IdCliente = idcliente;
            dt.Nombre = txtNombre.Text;
            dt.Apellido = txtApellido.Text;
            dt.Telefono = txtTelefono.Text;
            dt.Direccion = txtDireccion.Text;
            if (funcion.editar(dt))
            {
                MessageBox.Show("Cliente modificado", "Edicion correcta", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }
        private void eliminar()
        {
            eClientes dt = new eClientes();
            dClientes funcion = new dClientes();
            dt.IdCliente = idcliente;
            if (funcion.eliminar(dt))
            {
                MessageBox.Show("Cliente eliminado", "Eliminacion correcta", MessageBoxButtons.OKCancel);
                panelAgregarDatos.Visible = false;
            }
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        //      TERMINAN LAS FUNCIONES DE LAS OPERACIONES PRINCIPALES
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "")
            {
                insertar();
                mostrar();
            }
            else
            {
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
            mostrar();
        }

        private void dgvMostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToInt32(dgvMostrar.SelectedCells[2].Value.ToString());

            if (e.ColumnIndex == this.dgvMostrar.Columns["Editar"].Index)
            {
                limpiar();
                txtNombre.Text = dgvMostrar.SelectedCells[3].Value.ToString();
                txtApellido.Text = dgvMostrar.SelectedCells[4].Value.ToString();
                txtTelefono.Text = dgvMostrar.SelectedCells[5].Value.ToString();
                txtDireccion.Text = dgvMostrar.SelectedCells[6].Value.ToString();
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
                mostrar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
