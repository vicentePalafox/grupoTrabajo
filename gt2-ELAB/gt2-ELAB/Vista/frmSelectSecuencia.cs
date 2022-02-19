using gt2_ELAB.Funciones;

using MySqlX.XDevAPI.Relational;

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
    public partial class frmSelectSecuencia : Form
    {
        public frmSelectSecuencia()
        {
            InitializeComponent();
            CargarCBXPractica();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int idSec = new SQL_Secuencia().IdSec_X_Practica(Convert.ToInt32(cbxPractica.SelectedValue.ToString()));
            int registro = new SQL_Secuencia().ObtenerCupo(Convert.ToInt32(cbxEstacion.SelectedValue));

            if (registro > 0)
            {
                registro -= 1;

                bool DescontarCupo = new SQL_Secuencia().DescontarCupo(Convert.ToInt32(cbxEstacion.SelectedValue), registro);
                if (DescontarCupo)
                {
                    Entidad.Analista analista = new Entidad.Analista()
                    {
                        usuario = Entidad.Usuario.UsuarioName,
                        idSecuencia = idSec,
                        idEstacion = Convert.ToInt32(cbxEstacion.SelectedValue),
                        posicionAnalista = registro+1
                    };

                    bool insertAnaista = new SQL_Analista().InsertAnalista(analista);

                    if (insertAnaista)
                    {
                        DataTable table = new SQL_Operacion().ListaOperacion(Convert.ToInt32(cbxEstacion.SelectedValue), idSec);
                        Entidad.Practica practica = new Entidad.Practica();
                        bool CargaPractica = new SQL_Practica().BuscaPractica(cbxPractica.Text, out practica);
                        if (CargaPractica)
                        {//Estacion 1
                            int position = cbxEstacion.Text.IndexOf(" ");
                            string estacion = cbxEstacion.Text.Substring(position + 1, 1);
                            int noEstacion = int.Parse(estacion);
                            Console.WriteLine(estacion);
                            frmEjecucion vistaEjecucion = new frmEjecucion(table, practica.ciclos, idSec, noEstacion, (registro+1));
                            vistaEjecucion.Show();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Esatción Llena, seleccione otra estación", "AVISO");
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

        public void CargarCBXEstacion()
        {
            try
            {
                int idSec = new SQL_Secuencia().IdSec_X_Practica(Convert.ToInt32(cbxPractica.SelectedValue.ToString()));
                DataTable dt = new SQL_Estacion().ListaEstacion(idSec);
                cbxEstacion.DataSource = dt;

                DataRow r = dt.NewRow();
                r[0] = 0;
                r[1] = "";
                dt.Rows.InsertAt(r, 0);

                cbxEstacion.ValueMember = "id";
                cbxEstacion.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cbxPractica_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCBXEstacion();
        }

    }
}
