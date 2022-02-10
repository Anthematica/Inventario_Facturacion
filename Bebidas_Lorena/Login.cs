using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dato;
using Capa_Entidad;
using Capa_Negocio;

namespace Bebidas_Lorena
{
    public partial class Login : Form
    {
        Entidades objEntidad = new Entidades();
        Negocios objeNegocio = new Negocios();

        frmPrincipal frmPrincipal = new frmPrincipal();

        //Función de logueo
        void loginUsuarios() {
            DataTable dt = new DataTable();
            objEntidad.usuario = txtUsuario.Text;
            objEntidad.password = txtPassword.Text;

            dt = objeNegocio.NegocioUser(objEntidad);

            //Validación de el password y el usuario
            if (dt.Rows.Count > 0)
            { //Si encuentra una coincidencia
                frmPrincipal.ShowDialog();
                //Abrir el formulario principal si el usuario y contraseña son correctas
                Login login = new Login();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new frmPrincipal());

                //Limpiamos cajas de texto
                txtUsuario.Clear();
                txtPassword.Clear();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Clear();
                txtPassword.Clear();
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
