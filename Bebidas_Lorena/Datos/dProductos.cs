using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Windows.Forms;

namespace Datos
{
    class dProductos
    {
        private SqlCommand cmd = new SqlCommand();

        public bool insertar(eProductos dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_InsertarProducto", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Id_Producto", dt.IdProducto);
                cmd.Parameters.AddWithValue("@IDCATEGORIA ", dt.IdCategoria);
                cmd.Parameters.AddWithValue("@IDTIPO ", dt.IdTipo);
                cmd.Parameters.AddWithValue("@NOMBRE ", dt.NombreProducto);
                cmd.Parameters.AddWithValue("@PRECIO ", dt.Precio);
                cmd.Parameters.AddWithValue("@STOCK ", dt.Stock);
                cmd.Parameters.AddWithValue("@ESTADO ", dt.Estado);

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
        public bool editar(eProductos dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_ModificarProducto", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPRODUCTO", dt.IdProducto);
                cmd.Parameters.AddWithValue("@IDCATEGORIA ", dt.IdCategoria);
                cmd.Parameters.AddWithValue("@IDTIPO ", dt.IdTipo);
                cmd.Parameters.AddWithValue("@NOMBRE ", dt.NombreProducto);
                cmd.Parameters.AddWithValue("@PRECIO ", dt.Precio);
                cmd.Parameters.AddWithValue("@STOCK ", dt.Stock);
                cmd.Parameters.AddWithValue("@ESTADO ", dt.Estado);
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
        public bool eliminar(eProductos dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                cmd = new SqlCommand("SP_EliminarProducto", CONEXIONMAESTRA.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPRODUCTO", dt.IdProducto);
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
                cmd = new SqlCommand("SP_BuscarProducto", CONEXIONMAESTRA.conexion);
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
                cmd = new SqlCommand("SP_ListarProducto", CONEXIONMAESTRA.conexion);

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
                cmd = new SqlCommand("SP_BuscarProductoid", CONEXIONMAESTRA.conexion);
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
    }
}
