using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class eCategorias
    {
        private int idcategoria;
        private string nombrecategoria;
        private string descripcion;

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

        public string NombreCategoria
        {
            get
            {
                return nombrecategoria;
            }
            set
            {
                nombrecategoria = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public eCategorias()
        {

        }

        public eCategorias(int idcategoria, string nombrecategoria, string descripcion)
        {
            IdCategoria = idcategoria;
            NombreCategoria = nombrecategoria;
            Descripcion = descripcion;
        }
    }
}
