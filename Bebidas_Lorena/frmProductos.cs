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
    public partial class frmProductos : Form
    {
        int idproducto;
        int idc;
        //  FUNCIONES PARA LLENAR COMBOBOX Y DEVOLVER LOS DATOS
        //FUNCIONES PARA INTENTAR RECUPERAR EL NOMBRE DE LA CATEGORIA O TIPO Y NO LOS ID
        private void categoria()
        {
            DataTable dt2;
            dCategorias funcion = new dCategorias();
            dt2 = funcion.mostrar();
            dgvCategoria.DataSource = dt2;
        }
        private void tipo()
        {
            DataTable dt1;
            dTipos funcion = new dTipos();
            dt1 = funcion.mostrar();
            dgvTipo.DataSource = dt1;
        }
        private void bc()
        {
            DataTable dt;
            dCategorias funcion = new dCategorias();
            dt = funcion.buscarid(idc);
            dgvCategoria.DataSource = dt;
        }
        private void bt()
        {
            DataTable dt;
            dTipos funcion = new dTipos();
            dt = funcion.buscar(cboTipo.Text);
            dgvTipo.DataSource = dt;
        }
        //   FIN DEL INTENTO
        //  FUNCIONES PARA LLENAR LOS COMBOBOX
        private void mostrarcbocat()
        {
            DataTable dt;
            dCategorias funcion = new dCategorias();
            dt = funcion.mostrar();
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "NombreCategoria";
            cboCategoria.ValueMember = "Id_Categoria";
        }
        private void mostrarcbotipo()
        {
            DataTable dt;
            dTipos funcion = new dTipos();
            dt = funcion.mostrar();
            cboTipo.DataSource = dt;
            cboTipo.DisplayMember = "Descripcion";
            cboTipo.ValueMember = "Id_Tipo";
        }
        //  FIN DEL LLENADO DE COMBO    BOX
        //  FIN DE LAS FUNCIONES DE LOS COMBOBOX
        //          funciones para mostrar, ingresar, editar, eliminar, buscar y limpiar
        private void mostrar()
        {
            DataTable dt;
            dProductos funcion = new dProductos();
            dt = funcion.mostrar();
            dgvMostrar.DataSource = dt;
        }


        private void buscar()
        {
            DataTable dt;
            dProductos funcion = new dProductos();
            dt = funcion.buscar(txtBuscar.Text);
            dgvMostrar.DataSource = dt;
        }
        private void insertar()
        {
            eProductos dt = new eProductos();
            dProductos funcion = new dProductos();
            dt.IdCategoria = (int)cboCategoria.SelectedValue;
            dt.IdTipo = cboTipo.SelectedValue.ToString();
            dt.NombreProducto = txtNombreProd.Text;
            dt.Precio = float.Parse(txtPrecio.Text);
            dt.Stock = int.Parse(txtStock.Text);
            dt.Estado = 1;

            //idcategoria = Convert.ToInt32(dgvMostrar.SelectedCells[2].Value.ToString());
            if (funcion.insertar(dt))
            {
                MessageBox.Show("Producto registrado", "Registro correcto", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }

        private void editar()
        {
            eProductos dt = new eProductos();
            dProductos funcion = new dProductos();
            dt.IdProducto = idproducto;
            dt.IdCategoria = (int)cboCategoria.SelectedValue;
            dt.IdTipo = cboTipo.SelectedValue.ToString();
            dt.NombreProducto = txtNombreProd.Text;
            dt.Precio = float.Parse(txtPrecio.Text);
            dt.Stock = int.Parse(txtStock.Text);
            dt.Estado = 1;
            if (funcion.editar(dt))
            {
                MessageBox.Show("Producto modificado", "Edicion correcta", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }
        private void eliminar()
        {
            eProductos dt = new eProductos();
            dProductos funcion = new dProductos();
            dt.IdProducto = idproducto;
            if (funcion.eliminar(dt))
            {
                MessageBox.Show("Producto eliminado", "Eliminacion correcta", MessageBoxButtons.OK);
                panelAgregarDatos.Visible = false;
            }
        }

        private void limpiar()
        {
            txtNombreProd.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboCategoria.Text = "";
            cboTipo.Text = "";
        }

        //      TERMINAN LAS FUNCIONES DE LAS OPERACIONES PRINCIPALES
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos2_Load(object sender, EventArgs e)
        {
            tipo();
            categoria();
            mostrar();
            mostrarcbocat();
            mostrarcbotipo();
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
            if (cboCategoria.Text != "" || cboTipo.Text != "" || txtNombreProd.Text != "" || txtPrecio.Text != "" || txtStock.Text != "")
            {
                insertar();
                mostrar();
            }
            else
            {
                MessageBox.Show("Falta informacion por completar", "Datos", MessageBoxButtons.OK);
            }
            limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelAgregarDatos.Visible = false;
            limpiar();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            editar();
            mostrar();
            limpiar();
        }

        private void dgvMostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idproducto = Convert.ToInt32(dgvMostrar.SelectedCells[2].Value.ToString());

            if (e.ColumnIndex == this.dgvMostrar.Columns["Editar"].Index)
            {
                limpiar();
                idc = Convert.ToInt32(dgvMostrar.SelectedCells[3].Value.ToString());
                cboTipo.Text = dgvMostrar.SelectedCells[4].Value.ToString();
                bc();
                bt();
                cboTipo.Text = "";

                //cboCategoria.Text = dgvMostrar.SelectedCells[3].Value.ToString();
                //cboTipo.Text = dgvTipo.SelectedCells[1].Value.ToString(); //no funciona porque se tiene que seleccionar algo
                cboCategoria.Text = dgvCategoria.Rows[0].Cells[1].Value.ToString();
                cboTipo.Text = dgvTipo.Rows[0].Cells[1].Value.ToString();

                txtNombreProd.Text = dgvMostrar.SelectedCells[5].Value.ToString();
                txtPrecio.Text = dgvMostrar.SelectedCells[6].Value.ToString();
                txtStock.Text = dgvMostrar.SelectedCells[7].Value.ToString();
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

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
