using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class eTipos
    {
        private string idtipo;
        private string descripcion;

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

        public eTipos()
        {

        }

        public eTipos(string idtipo, string descripcion)
        {
            IdTipo = idtipo;
            Descripcion = descripcion;
        }
    }
}
