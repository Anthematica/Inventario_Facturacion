using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class CONEXIONMAESTRA
    {
        public static SqlConnection conexion = new SqlConnection("Data source = DESKTOP-V1HDRHB; Initial catalog = Agencia de bebidas; integrated security= true");
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
