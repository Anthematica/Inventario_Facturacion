using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Configuration;
using System.Data;
using Capa_Entidad;

namespace Capa_Dato
{
    public class Datos
    {
        SqlConnection cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable DataUser(Entidades obje) {

            SqlCommand cmd = new SqlCommand("SP_ValidarLogin", cadena);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoginUsuario", obje.usuario);
            cmd.Parameters.AddWithValue("@PasswordUsuario", obje.password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt; 

        }

    }
}
