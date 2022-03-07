using gt2_ELAB.Entidad;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gt2_ELAB.Vista
{
    public partial class frmAnalisis : Form
    {
        string idConfig;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public frmAnalisis()
        {
            InitializeComponent();
            CargaListBox();
        }

        public void CargaListBox()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = new Funciones.SQL_Analista().listaAnalisis(Usuario.UsuarioName);

            lbxListaAnalisis.DataSource = null;

            lbxListaAnalisis.ValueMember = "id";
            lbxListaAnalisis.DisplayMember = "Practica";
            lbxListaAnalisis.DataSource = dt;
        }

        public void ColorEstacionAct(int noEstacion)
        {
            switch (noEstacion)
            {
                case 1:
                    panelEst1.BackColor = Color.IndianRed;
                    panelEst1.ForeColor = Color.White;

                    panelEst2.BackColor = SystemColors.Control;
                    panelEst2.ForeColor = SystemColors.ControlText;

                    panelEst3.BackColor = SystemColors.Control;
                    panelEst3.ForeColor = SystemColors.ControlText;
                    break;
                case 2:
                    panelEst1.BackColor = SystemColors.Control;
                    panelEst1.ForeColor = SystemColors.ControlText;

                    panelEst2.BackColor = Color.IndianRed;
                    panelEst2.ForeColor = Color.White;

                    panelEst3.BackColor = SystemColors.Control;
                    panelEst3.ForeColor = SystemColors.ControlText;
                    break;
                case 3:
                    panelEst1.BackColor = SystemColors.Control;
                    panelEst1.ForeColor = SystemColors.ControlText;

                    panelEst2.BackColor = SystemColors.Control;
                    panelEst2.ForeColor = SystemColors.ControlText;

                    panelEst3.BackColor = Color.IndianRed;
                    panelEst3.ForeColor = Color.White;
                    break;
            }
        }

        private void btnNuevaP_Click(object sender, EventArgs e)
        {
            frmSelectSecuencia vistaNuevaPractica = new frmSelectSecuencia();
            vistaNuevaPractica.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnVisualizarT_Click(object sender, EventArgs e)
        {
            int idPrac, noAnalista, noEst, ciclos;
            string escuela, fecha;

            _ = new Funciones.SQL_Analista().SelecionaPractica(int.Parse(idConfig), out idPrac, out noAnalista, out escuela, out noEst, out fecha, out ciclos);

            DataTable dtProcesos = new DataTable();
            dtProcesos = new Funciones.SQL_Analista().CargaListaOper(Usuario.UsuarioName, fecha, noAnalista, noEst);
            
            frmResultados vistaresulados = new frmResultados(dtProcesos,fecha, ciclos, idPrac);
            vistaresulados.Show();
        }

        public string fechaRangoIni(string fecha)
        {
            string resp;
            try
            {
                string hora = fecha.Substring(11);

                DateTime time = new DateTime();
                TimeSpan timeSpan = new TimeSpan(0, 5, 0);
                time = DateTime.Parse(hora);
                resp = $"{fecha.Substring(0, 11)}{time.Subtract(timeSpan).ToString("HH:mm")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = string.Empty;
            }
            return resp;
        }

        public string fechaRangoFin(string fecha)
        {
            string resp;
            try
            {
                string hora = fecha.Substring(11);

                DateTime time = new DateTime();
                time = DateTime.Parse(hora).AddMinutes(5);
                resp = $"{fecha.Substring(0, 11)}{time.ToString("HH:mm")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = string.Empty;
            }
            return resp;
        }

        private void lbxListaAnalisis_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxListaAnalisis.SelectedIndex != -1)
            {
                idConfig = lbxListaAnalisis.SelectedValue.ToString();
                int idConf;
                if (int.TryParse(idConfig, out idConf))
                {
                    int idPrac, noAnalista, noEst, ciclos;
                    string escuela, fecha;
                    _ = new Funciones.SQL_Analista().SelecionaPractica(idConf, out idPrac, out noAnalista, out escuela, out noEst, out fecha, out ciclos);

                    string fechaIni = fechaRangoIni(fecha);
                    string fechaFin = fechaRangoFin(fecha);

                    ColorEstacionAct(noEst);

                    string tobs1, tobs2, tobs3, tnor1, tnor2, tnor3, test1, test2, test3;

                    bool tiempos = new Funciones.SQL_Analista().BuscaTiempoAnalistas(noAnalista, idPrac, escuela, fechaIni, fechaFin, out tobs1, out tobs2, out tobs3, out test1, out test2, out test3, out tnor1, out tnor2, out tnor3);
                    if (tiempos)
                    {
                        lblTo1.Text = tobs1;
                        lblTo2.Text = tobs2;
                        lblTo3.Text = tobs3;

                        lblTn1.Text = tnor1;
                        lblTn2.Text = tnor2;
                        lblTn3.Text = tnor3;

                        lblTe1.Text = test1;
                        lblTe2.Text = test2;
                        lblTe3.Text = test3;

                        lblTo4.Text = ((decimal.Parse(tobs1) + decimal.Parse(tobs2) + decimal.Parse(tobs3))/3).ToString("N3");
                        lblTn4.Text = ((decimal.Parse(tnor1) + decimal.Parse(tnor2) + decimal.Parse(tnor3))/3).ToString("N3");
                        lblTe4.Text = ((decimal.Parse(test1) + decimal.Parse(test2) + decimal.Parse(test3))/3).ToString("N3");
                    }
                    else
                    {
                        lblTo1.Text = "0.0";
                        lblTo2.Text = "0.0";
                        lblTo3.Text = "0.0";
                        lblTo4.Text = "0.0";

                        lblTn1.Text = "0.0";
                        lblTn2.Text = "0.0";
                        lblTn3.Text = "0.0";
                        lblTn4.Text = "0.0";

                        lblTe1.Text = "0.0";
                        lblTe2.Text = "0.0";
                        lblTe3.Text = "0.0";
                        lblTe4.Text = "0.0";
                    }
                }
            }

        }

        private void btnModificarR_Click(object sender, EventArgs e)
        {
            int idPrac, noAnalista, noEst, ciclos;
            string escuela, fecha;

            _ = new Funciones.SQL_Analista().SelecionaPractica(int.Parse(idConfig), out idPrac, out noAnalista, out escuela, out noEst, out fecha, out ciclos);

            DataTable dtProcesos = new DataTable();
            dtProcesos = new Funciones.SQL_Analista().CargaListaOper(Usuario.UsuarioName, fecha, noAnalista, noEst);

            new frmEvaluacionResult(dtProcesos, idConfig, ciclos).ShowDialog();
            CargaListBox();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void frmAnalisis_Enter(object sender, EventArgs e)
        {
            CargaListBox();
        }
    }
}
