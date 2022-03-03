using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gt2_ELAB.Vista
{
    public partial class frmAnalisis : Form
    {
        public frmAnalisis()
        {
            InitializeComponent();
        }

        private void btnNuevaP_Click(object sender, EventArgs e)
        {
            frmSelectSecuencia vistaNuevaPractica = new frmSelectSecuencia();
            //DialogResult dialogResult;
            /*dialogResult =*/ vistaNuevaPractica.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnVisualizarT_Click(object sender, EventArgs e)
        {
            frmResultados vistaresulados = new frmResultados();
            vistaresulados.Show();
        }
    }
}
