using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt2_ELAB.Entidad
{
    internal class Estacion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int posicion { get; set; }
        public int idSecuencia { get; set; }
        public int espacio { get; set; }
        public int finalizo { get; set; }
    }
}
