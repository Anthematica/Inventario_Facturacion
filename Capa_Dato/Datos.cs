using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Configuration;
using System.Data;
using Capa_Entidad;
using System.Security.Cryptography;

namespace Capa_Dato
{
    public class Datos
    {
        SqlConnection cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable ValidateUser (Entidades obje) {
            SqlCommand cmd = new SqlCommand("SP_ValidarLogin", cadena);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoginUsuario", obje.usuario);
            cmd.Parameters.AddWithValue("@PasswordUsuario", EncryptSHA512(obje.password).ToLower());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static String EncryptSHA512 (String source)
        {
            if (String.IsNullOrWhiteSpace(source)) return String.Empty;
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                return BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
        }
    }
}
