using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dato;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class Negocios
    {
        Datos obj = new Datos();

        public DataTable NegocioUser(Entidades obje) {
            return obj.ValidateUser(obje);
        }
    }
}
