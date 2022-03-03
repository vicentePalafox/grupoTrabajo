using gt2_ELAB.Funciones;

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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre;
            string escuela;
            SQL_Usuario usuario = new SQL_Usuario();
            bool result= usuario.Login(txtUsuario.Text, txtContraseña.Text, out nombre, out escuela);
            if (result == true)
            {
                Console.WriteLine(nombre + escuela);
                Entidad.Usuario.UsuarioName = nombre;
                Entidad.Usuario.UsuarioEscuela=escuela;

                frmAnalisis vistaAnalisis = new frmAnalisis();
                Hide();
                vistaAnalisis.Show();
            }
            else
            {
                Console.WriteLine("No existe el usuario");
            }
        }
    }
}
