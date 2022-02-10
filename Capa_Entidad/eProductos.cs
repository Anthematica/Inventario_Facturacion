using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class eProductos
    {
        private int idproducto;
        private int idcategoria;
        private string idtipo;
        private string nombreproducto;
        private float precio;
        private int stock;
        private int estado;

        public int IdProducto
        {
            get
            {
                return idproducto;
            }
            set
            {
                idproducto = value;
            }
        }
        public int IdCategoria
        {
            get
            {
                return idcategoria;
            }
            set
            {
                idcategoria = value;
            }
        }

        public string IdTipo
        {
            get
            {
                return idtipo;
            }
            set
            {
                idtipo = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return nombreproducto;
            }
            set
            {
                nombreproducto = value;
            }
        }
        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
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

        public eProductos()
        {

        }

        public eProductos(int idproducto, int idcategoria, string idtipo, string nombreproducto, float precio, int stock, int estado)
        {
            IdProducto = idproducto;
            IdCategoria = idcategoria;
            IdTipo = idtipo;
            NombreProducto = nombreproducto;
            Precio = precio;
            Stock = stock;
            Estado = estado;
        }
    }
}
