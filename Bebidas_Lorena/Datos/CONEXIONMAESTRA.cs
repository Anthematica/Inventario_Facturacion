using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    class CONEXIONMAESTRA
    {
        //CADENA DE CONEXION VIEJA
        //public static SqlConnection conexion = new SqlConnection("Data source = DESKTOP-V1HDRHB; Initial catalog = Agencia de bebidas; integrated security= true");

        //CADENA DE CONEXION ACTUAL
        public static SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        // SqlConnection cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public static void abrir()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

        }
        public static void cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

        }
    }
}
