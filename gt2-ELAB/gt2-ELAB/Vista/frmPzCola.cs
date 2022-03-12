using System;
using System.Windows.Forms;

namespace gt2_ELAB.Vista
{
    public partial class frmPzCola : Form
    {
        public frmPzCola()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPZcola.Text == string.Empty)
                MessageBox.Show("Ingrese un numero");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            } 
        }
    }
}
