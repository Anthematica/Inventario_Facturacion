using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;

namespace Datos
{
    class dClientes
    {
        private SqlCommand cmd = new SqlCommand();

        public bool insertar(eClientes dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_InsertarCliente", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Id_Clienter", dt.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", dt.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", dt.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", dt.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", dt.Direccion);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool editar(eClientes dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_ModificarCliente", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", dt.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", dt.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", dt.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", dt.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", dt.Direccion);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool eliminar(eClientes dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_EliminarCliente", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", dt.IdCliente);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public DataTable buscar(string parametro)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_BuscarCliente", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscador", parametro);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public DataTable mostrar()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_ListarCliente", CONEXIONMAESTRA.conexion);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public DataTable buscarid(int parametroint)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_BuscarClienteid", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscador", parametroint);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public DataTable mostrarNomb()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_NombreCliente", CONEXIONMAESTRA.conexion);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
    }
}
