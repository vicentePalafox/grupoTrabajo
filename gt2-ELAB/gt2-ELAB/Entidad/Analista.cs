using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt2_ELAB.Entidad
{
    internal class Analista
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public int idSecuencia { get; set; }
        public int idEstacion { get; set; }
        public int posicionAnalista { get; set; }
        public string tObservado { get; set; }
        public string tNormal { get; set; }
        public string tEstandar { get; set; }
        public int finalizo { get; set; }
    }
}
