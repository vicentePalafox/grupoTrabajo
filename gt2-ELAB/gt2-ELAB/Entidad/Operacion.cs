using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt2_ELAB.Entidad
{
    internal class Operacion
    {
        public int id { get; set; }
        public int noPosicion { get; set; }
        public int idSecuencia { get; set; }
        public int estacion { get; set; }
        public string descripcion { get; set; }
        public byte[] urlImagen { get; set; }
    }
}
