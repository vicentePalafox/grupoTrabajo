using gt2_ELAB.Funciones;
using gt2_ELAB.Vista;

using System;
using System.Data;
using System.Windows.Forms;

namespace gt2_ELAB
{
    public partial class frmSelectSecuencia : Form
    {
        public frmSelectSecuencia()
        {
            InitializeComponent();
            CargarCBXPractica();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if(cbxPractica.Text != "")
            {
                int registro = 0;
                int PosicionEstacion = 0;
                Entidad.Analista analista = null;
                bool insertAnaista = false;
                int idSec = new SQL_Secuencia().IdSec_X_Practica(Convert.ToInt32(cbxPractica.SelectedValue.ToString()));

                for (int i = 1; i <= 12; i++)
                {
                    registro = new SQL_Secuencia().ObtenerCupo(idSec, i);

                    if (registro.Equals(null) || registro.Equals(0))
                    {
                        analista = new Entidad.Analista()
                        {
                            usuario = Entidad.Usuario.UsuarioName,
                            idSecuencia = idSec,
                            idEstacion = new SQL_Estacion().BuscaIdEstacion(idSec, "Estación 1"),
                            posicionAnalista = i
                        };
                        PosicionEstacion = 1;
                        insertAnaista = new SQL_Analista().InsertAnalista(analista);
                        break;
                    }
                    else if (registro.Equals(1))
                    {
                        analista = new Entidad.Analista()
                        {
                            usuario = Entidad.Usuario.UsuarioName,
                            idSecuencia = idSec,
                            idEstacion = new SQL_Estacion().BuscaIdEstacion(idSec, "Estación 2"),
                            posicionAnalista = i
                        };
                        PosicionEstacion = 2;
                        insertAnaista = new SQL_Analista().InsertAnalista(analista);
                        break;
                    }
                    else if (registro.Equals(2))
                    {
                        analista = new Entidad.Analista()
                        {
                            usuario = Entidad.Usuario.UsuarioName,
                            idSecuencia = idSec,
                            idEstacion = new SQL_Estacion().BuscaIdEstacion(idSec, "Estación 3"),
                            posicionAnalista = i
                        };
                        PosicionEstacion = 3;
                        insertAnaista = new SQL_Analista().InsertAnalista(analista);
                        break;
                    }

                    if (registro.Equals(3) && i == 12)
                    {
                        MessageBox.Show("La practica ya esta llena");
                        insertAnaista = false;
                    }
                }

                if (insertAnaista)
                {
                    Entidad.Practica practica = new Entidad.Practica();
                    bool CargaPractica = new SQL_Practica().BuscaPractica(cbxPractica.Text, out practica);
                    if (CargaPractica)
                    {
                        int noEstacion = PosicionEstacion;
                        DataTable table = new SQL_Operacion().ListaOperacion(noEstacion, idSec);
                        int idPractica = Convert.ToInt32(cbxPractica.SelectedValue);

                        if (noEstacion != 1)
                        {
                            frmPzCola frmPz = new frmPzCola();
                            DialogResult result = frmPz.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                int pzcola = int.Parse(frmPz.txtPZcola.Text);
                                frmEjecucion vistaEjecucion = new frmEjecucion(table, practica.ciclos, idSec, noEstacion, analista.posicionAnalista, idPractica, pzcola);
                                vistaEjecucion.Show();
                            }
                        }
                        else
                        {
                            frmEjecucion vistaEjecucion = new frmEjecucion(table, practica.ciclos, idSec, noEstacion, analista.posicionAnalista, idPractica, 0);
                            vistaEjecucion.Show();
                        }
                        Close();
                    }
                }
            }
        }

        public void CargarCBXPractica()
        {
            try
            {
                DataTable dt = new SQL_Practica().ListaPractica();
                cbxPractica.DataSource = dt;

                DataRow r = dt.NewRow();
                r[0] = 0;
                r[1] = "";
                dt.Rows.InsertAt(r, 0);

                cbxPractica.ValueMember = "id";
                cbxPractica.DisplayMember = "nombrePractica";
                cbxPractica.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
