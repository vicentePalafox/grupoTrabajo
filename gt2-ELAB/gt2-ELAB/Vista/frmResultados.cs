using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gt2_ELAB
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        public frmResultados(DataTable table, string fecha, int idSec)
        {
            InitializeComponent();

            Entidad.Secuencia secuencia = new Entidad.Secuencia();
            new Funciones.SQL_Secuencia().BuscaSecuencia(idSec, out secuencia);

            lblAnalisis.Text = secuencia.nombre;
            lblResultados.Text = fecha;
            dgvMesa1.DataSource = table;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
