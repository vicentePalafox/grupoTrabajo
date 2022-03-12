using System;
using System.Windows.Forms;

namespace gt2_ELAB.Vista
{
    public partial class frmCargaReporte : Form
    {
        public frmCargaReporte()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtProfesor.Text != "" && txtMateria.Text != "")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Comprobar campos vacios", "ERROR");
        }
    }
}
