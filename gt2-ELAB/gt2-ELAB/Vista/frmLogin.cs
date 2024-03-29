﻿using gt2_ELAB.Funciones;

using System;
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
                vistaAnalisis.lblUsuario.Text = nombre;
                Hide();
                vistaAnalisis.Show();
            }
            else
                Console.WriteLine("No existe el usuario");
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                btnIniciar.PerformClick();
        }
    }
}
