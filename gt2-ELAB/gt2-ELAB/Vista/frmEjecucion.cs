using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;
using Microsoft.VisualBasic;

namespace gt2_ELAB
{
    public partial class frmEjecucion : Form
    {
        int idSecuencia, cicloSec, numero_estacion, numeroAnalista;

        int conteo = 3;
        int index = 0;

        double iniciaTiempo;

        DataTable DTactividades;
        public frmEjecucion()
        {
            InitializeComponent();
        }

        public frmEjecucion(DataTable table, int ciclo, int idSec, int noEstacion, int noAnalista)
        {
            InitializeComponent();
            DTactividades = table;
            idSecuencia = idSec;
            cicloSec = ciclo;
            numero_estacion = noEstacion;
            numeroAnalista = noAnalista;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void frmEjecucion_Load(object sender, EventArgs e)
        {
            if (!numero_estacion.Equals(1))
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                tmrRegresivo.Start();
            }
        }

        public void IniciaTiempo(out double initTime)
        {
            double mili, seg, min, h;

            mili = DateTime.Now.Millisecond / 1000;
            seg = DateTime.Now.Second;
            min = DateTime.Now.Minute * 60;
            h = DateTime.Now.Hour * 3600;

            initTime = mili + seg + min + h;
        }

        public double ComparaTiempo(double horaInicial)
        {
            double compSeg, mili, seg, min, hour, actualhour;

            mili = DateTime.Now.Millisecond / 1000;
            seg = DateTime.Now.Second;
            min = DateTime.Now.Minute * 60;
            hour = DateTime.Now.Hour * 3600;
            actualhour = mili + seg + min + hour;
            compSeg = actualhour - horaInicial;

            return compSeg;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if(worker.CancellationPending == true)
                e.Cancel=true;
            else
            finEstacion();
        }

        private void tmrRegresivo_Tick(object sender, EventArgs e)
        {
            lblContador.Text = conteo.ToString();
            conteo -= 1;

            if(conteo == -1)
            {
                tmrRegresivo.Stop();
                tmrProceso.Start();
                lblContador.Text = string.Empty;

                IniciaTiempo(out iniciaTiempo);
            }
        }

        private void tmrProceso_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text =Strings.FormatNumber(ComparaTiempo(iniciaTiempo), 3);
        }

        public void finEstacion()
        {
            int finalizo = 0;
            while (finalizo == 0)
            {
                try
                {
                    finalizo = new Funciones.SQL_Practica().FinalizoEstAnterior(idSecuencia, (numero_estacion - 1), numeroAnalista);
                    if (finalizo == 0)
                    {
                        lblAviso.Invoke(new Action(() => lblAviso.Text = "esperando estacion anterior"));
                        btnInicia.Invoke(new Action(() => btnInicia.Enabled = false));
                    }
                    else
                    {
                        lblAviso.Invoke(new Action(() => lblAviso.Text = "Estación lista para comenzar"));
                        btnInicia.Invoke(new Action(() => btnInicia.Enabled = true));
                        //backgroundWorker1.CancelAsync();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            backgroundWorker1.CancelAsync();
        }

        

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
