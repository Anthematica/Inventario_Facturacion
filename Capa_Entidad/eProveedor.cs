using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class eProveedor
    {
        private int idproveedor;
        private string nombreempresa;
        private string nombreproveedor;
        private string telefono;
        private string direccion;
        private int estado;

        public int IdProveedor
        {
            get
            {
                return idproveedor;
            }
            set
            {
                idproveedor = value;
            }
        }

        public string NombreEmpresa
        {
            get
            {
                return nombreempresa;
            }
            set
            {
                nombreempresa = value;
            }
        }

        public string NombreProveedor
        {
            get
            {
                return nombreproveedor;
            }
            set
            {
                nombreproveedor = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public eProveedor()
        {

        }

        public eProveedor(int idproveedor, string nombreempresa, string nombreproveedor, string telefono, string direccion)
        {
            IdProveedor = idproveedor;
            NombreEmpresa = nombreempresa;
            NombreProveedor = nombreproveedor;
            Telefono = telefono;
            Direccion = direccion;
            Estado = estado;
        }
    }
}
