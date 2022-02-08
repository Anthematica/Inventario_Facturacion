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
using Capa_Negocio;

namespace Bebidas_Lorena
{
    public partial class Login : Form
    {
        Entidades objEntidad = new Entidades();
        Negocios objeNegocio = new Negocios();

        Principal frmPrincipal = new Principal();

        //Función de logueo
        void loginUsuarios() {
            DataTable dt = new DataTable();
            objEntidad.usuario = txtUsuario.Text;
            objEntidad.password = txtPassword.Text;

            dt = objeNegocio.NegocioUser(objEntidad);

            //Validación de el password y el usuario 
            if (dt.Rows.Count > 0)
            { //Si encuentra una coincidencia
                MessageBox.Show("Bienvenido " + dt.Rows[0][3].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal.ShowDialog();


                Login login = new Login();
                //login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                //Limpiamos cajas de texto
                txtUsuario.Clear();
                txtPassword.Clear();

            }
            else {
                MessageBox.Show("Usuario o Contraseña Incorrecta ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUsuarios();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
