using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using gt2_ELAB.Entidad;
using gt2_ELAB.Funciones;
using gt2_ELAB.Vista;

namespace gt2_ELAB
{
    public partial class frmEjecucion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        string horaInicio;
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch swTiempoObs = new Stopwatch();
        int idSecuencia, idPract, numero_estacion, numeroAnalista;
        int cicloSec, totalProcesos, pzCola, pzcolaIni;

        int SecDisponible;

        //toma de la secuencia en turno
        int cicloActual = 0, ProcesoActual = 0;

        int conteo = 3;
        bool imagenesActivados = false;

        double iniciaTiempo;

        DataTable DTactividades;
        DataTable DT_tiempos;

        public frmEjecucion()
        {
            InitializeComponent();
        }

        public frmEjecucion(DataTable table, int ciclo, int idSec, int noEstacion, int noAnalista, int idPractica, int pzCola)
        {
            InitializeComponent();
            panelInicio.BackColor = Color.Firebrick;

            horaInicio = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            DTactividades = table;
            idSecuencia = idSec;
            idPract = idPractica;
            cicloSec = ciclo;
            numero_estacion = noEstacion;
            numeroAnalista = noAnalista;

            DT_tiempos = new DataTable();
            DT_tiempos.Columns.Add("id", typeof(int)).AutoIncrement = true;
            DT_tiempos.Columns["id"].AutoIncrementSeed = 0;
            DT_tiempos.Columns["id"].AutoIncrementStep = 1;
            DT_tiempos.Columns.Add("posicionAct", typeof(int));
            DT_tiempos.Columns.Add("tiempoOBS", typeof(string));
            DT_tiempos.Columns.Add("cicloA", typeof(int));


            totalProcesos = DTactividades.Rows.Count;
            this.pzCola = pzCola;
            pzcolaIni = pzCola;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            lblCicloTotal.Text = ciclo.ToString();
            lblEstacion.Text = noEstacion.ToString();
            lblPzCola.Text = pzCola.ToString();

            new SQL_Analista().InsertaPzCola(idSecuencia, noEstacion, numeroAnalista, pzCola);

            if (noEstacion == 1)
            {
                label7.Visible = false;
                lblPzCola.Visible = false;
            }
        }

        private void frmEjecucion_Load(object sender, EventArgs e)
        {
            //comienza cuenta regresiva para buscar a los 2 analistas restantes
            stopwatch.Start();
            tmrBuscaGrupo.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker.CancellationPending == true)
                e.Cancel = true;
            else
                finEstacion();
        }

        private void tmrRegresivo_Tick(object sender, EventArgs e)
        {
            lblContador.Text = conteo.ToString();
            conteo -= 1;

            if (conteo == -1)
            {
                tmrRegresivo.Stop();
                tmrProceso.Start();
                lblContador.Text = string.Empty;
                lblAviso.Text = string.Empty;

                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[0][2]);
                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();

                swTiempoObs.Start();

                if (numero_estacion != 1)
                    tmrPzCola.Enabled = true;
                conteo = 3;
            }
        }

        private void IniciaTiempoSec()
        {
            ProcesoActual = 0;
            tmrRegresivo.Enabled = true;
            imagenesActivados = true;
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            ProcesoActual = 0;

            btnInicia.Enabled = false;
            tmrRegresivo.Enabled = true;
            imagenesActivados = true;
        }

        private void lblCicloAct_TextChanged(object sender, EventArgs e)
        {
            if(numero_estacion == 1)
            {
                if (lblCicloAct.Text == lblCicloTotal.Text)
                {
                    imagenesActivados = false;
                    swTiempoObs.Stop();
                    tmrProceso.Stop();
                    new SQL_Analista().UpdateStatusAnalista(idSecuencia, numeroAnalista, numero_estacion);
                    MessageBox.Show($"Se acabo el proceso de la estacion: {numero_estacion}");

                    if (backgroundWorker1.IsBusy != true)
                    {
                        // Start the asynchronous operation.
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmrBuscaGrupo_Tick(object sender, EventArgs e)
        {
            try
            {
                int iniciaT = 0;
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);
                TimeSpan tsInverso = new TimeSpan(0, 0, 1, 0);
                TimeSpan result = tsInverso.Subtract(ts);

                lblMin.Text = result.Minutes.ToString().Length < 2 ? $"0{result.Minutes.ToString()}" : result.Minutes.ToString();
                lblseg.Text = result.Seconds.ToString().Length < 2 ? $"0{result.Seconds.ToString()}" : result.Seconds.ToString();

                iniciaT = new SQL_Secuencia().buscaIniciaTAnalista1(idSecuencia);

                if (lblMin.Text.Equals("00") && lblseg.Text.Equals("00") || iniciaT == 1)
                {
                    if (numeroAnalista == 1 && numero_estacion == 1)
                        new SQL_Secuencia().ActualizaIniciaTAnalista1(idSecuencia);

                    int ConfirmarGrupo = new SQL_Secuencia().ObtenerCupo(idSecuencia, numeroAnalista);
                    tmrBuscaGrupo.Enabled = false;
                    stopwatch.Stop();
                    lblAvisoBusqueda.Visible = false;
                    lblMin.Visible = false;
                    lblseg.Visible = false;
                    label5.Visible = false;

                    if (ConfirmarGrupo == 3 && numero_estacion == 1)
                    {
                        //btnInicia.Enabled = true;
                        panelInicio.BackColor = Color.LimeGreen;
                        IniciaTiempoSec();
                    }
                    else if (ConfirmarGrupo == 3 && numero_estacion != 1)
                    {
                        if (lblPzCola.Text.Equals("0"))
                        {
                            //esperaa q exista una pz en cola
                            tmrPzCola.Enabled = true;
                        }
                        else
                        {
                            //comienza la secuencia
                            IniciaTiempoSec();
                            //btnInicia.Enabled = true;
                        }
                    }
                    else if (ConfirmarGrupo != 3)
                    {
                        MessageBox.Show("Grupo incompleto");
                        bool eliminaAnanista = new SQL_Analista().DeleteAnalista(idSecuencia, numeroAnalista);
                        if (eliminaAnanista)
                            Console.WriteLine("analista eliminado");
                        else
                            Console.WriteLine("error al eliminar analista");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tmrProceso_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)swTiempoObs.ElapsedMilliseconds);

            lblTseg.Text = ts.Seconds.ToString().Length < 2 ? $"0{ts.Seconds.ToString()}" : ts.Seconds.ToString();
            lblTmilis.Text = ts.Milliseconds.ToString().Length < 3 ? $"0{ts.Milliseconds.ToString()}" : ts.Milliseconds.ToString();
        }

        private void tmrPzCola_Tick(object sender, EventArgs e)
        {
            pzCola = new SQL_Analista().BuscaPZcola(idSecuencia, numero_estacion, numeroAnalista);
            lblPzCola.Text = pzCola.ToString();

            if (/*(lblPzCola.Text == pzcolaIni.ToString()) &&*/ (lblCicloAct.Text == lblCicloTotal.Text))
            {
                //if(pzCola < cicloSec) //pzCola < cicloSec
                {
                    imagenesActivados = false;
                    swTiempoObs.Stop();
                    tmrProceso.Enabled = false;

                    new SQL_Analista().UpdateStatusAnalista(idSecuencia, numeroAnalista, numero_estacion);
                }
                //else if(pzCola == cicloSec && (!imagenesActivados)){
                if(int.Parse(lblPzCola.Text) == pzcolaIni)
                {
                    tmrPzCola.Enabled = false;
                    MessageBox.Show($"Se acabo el proceso de la estacion: {numero_estacion}");
                    imagenesActivados = false;
                    swTiempoObs.Stop();
                    tmrProceso.Enabled = false;

                    if (backgroundWorker1.IsBusy != true)
                        backgroundWorker1.RunWorkerAsync();
                }
            }



            if (!pzCola.Equals(0) && (lblCicloAct.Text != lblCicloTotal.Text))//quitar && (lblCicloAct.Text == lblCicloTotal.Text)
            {
                if (tmrProceso.Enabled == false && (lblCicloAct.Text != lblCicloTotal.Text))
                {
                    panelInicio.BackColor = Color.LimeGreen;
                    imagenesActivados = true;
                    swTiempoObs.Start();
                    tmrProceso.Enabled = true;
                    pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[0][2]);
                    lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                }

                //if(lblCicloAct.Text == lblCicloTotal.Text)
                //{
                //    //if(pzCola < cicloSec) //pzCola < cicloSec
                //    {
                //        imagenesActivados = false;
                //        swTiempoObs.Stop();
                //        tmrProceso.Enabled = false;

                //        new SQL_Analista().UpdateStatusAnalista(idSecuencia, numeroAnalista, numero_estacion);  
                //    }
                //    //else if(pzCola == cicloSec && (!imagenesActivados)){
                //        tmrPzCola.Enabled = false;
                //        MessageBox.Show($"Se acabo el proceso de la estacion: {numero_estacion}");
                //        imagenesActivados = false;
                //        swTiempoObs.Stop();
                //        tmrProceso.Enabled = false;

                //        muestraTabla();

                //        if (backgroundWorker1.IsBusy != true)
                //            backgroundWorker1.RunWorkerAsync();
                //    //}
                //}
            }
        }

        private void pictureTarea_Click(object sender, EventArgs e)
        {
            int TPmenos = totalProcesos - 1;
            try
            {
                if (imagenesActivados)
                {
                    if (numero_estacion == 1)/////////////////////estacion 1////////////////////////////
                    {
                        if (cicloActual < cicloSec)
                        {
                            if (ProcesoActual < TPmenos)
                            {
                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);
                                swTiempoObs.Restart();

                                ProcesoActual++;
                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                            }
                            else
                            {
                                cicloActual++;
                                lblCicloAct.Text = cicloActual.ToString();

                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);

                                ProcesoActual = 0;
                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                                new SQL_Analista().UpdatePzColaMAS(idSecuencia, numeroAnalista, 2, 1);
                                
                            }
                        }
                        else
                        {
                            //imagenesActivados = false;
                            //swTiempoObs.Stop();
                            //tmrProceso.Stop();
                            //new SQL_Analista().UpdateStatusAnalista(idSecuencia, numeroAnalista, numero_estacion);
                            //MessageBox.Show($"Se acabo el proceso de la estacion: {numero_estacion}");

                            //if (backgroundWorker1.IsBusy != true)
                            //{
                            //    // Start the asynchronous operation.
                            //    backgroundWorker1.RunWorkerAsync();
                            //}
                        }
                    }
                    else if (numero_estacion == 2)////////////////////estacion 2//////////////////////////
                    {
                        SecDisponible = int.Parse(lblPzCola.Text);

                        //if ((SecDisponible != 0) && (cicloActual < cicloSec)) // (SecDisponible != 0) && (cicloActual <= cicloSec)         cicloActual <= SecDisponible) && (cicloActual <= cicloSec
                        {
                            if (ProcesoActual < TPmenos)
                            {
                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);
                                swTiempoObs.Restart();

                                ProcesoActual++;
                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                            }
                            else
                            {
                                new SQL_Analista().UpdatePzColaMENOS(idSecuencia, numeroAnalista, numero_estacion, 1);

                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);

                                cicloActual++;

                                lblCicloAct.Text = cicloActual.ToString();
                                ProcesoActual = 0;
                                pzCola = pzCola - 1;
                                if (pzCola == 0)
                                {
                                    imagenesActivados = false;
                                    swTiempoObs.Reset();
                                    tmrProceso.Enabled = false;
                                }

                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();

                                new SQL_Analista().UpdatePzColaMAS(idSecuencia, numeroAnalista, 3, 1);
                            }
                        }

                        #region no sirve
                        //if ((SecDisponible != 0) && (cicloActual <= cicloSec)) //cicloActual <= SecDisponible) && (cicloActual <= cicloSec
                        //{
                        //    if (ProcesoActual < TPmenos)
                        //    {
                        //        DataRow row = DT_tiempos.NewRow();
                        //        row[0] = ProcesoActual;
                        //        row[1] = $"{lblTseg.Text}:{lblTmilis.Text}";
                        //        DT_tiempos.Rows.Add(row);
                        //        swTiempoObs.Restart();

                        //        ProcesoActual++;
                        //        pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                        //        lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                        //    }
                        //    else
                        //    {
                        //        new SQL_Analista().UpdatePzColaMENOS(idSecuencia, numeroAnalista, numero_estacion, 1);
                        //        cicloActual++;
                        //        ProcesoActual = 0;
                        //        pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                        //        lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                        //        new SQL_Analista().UpdatePzColaMAS(idSecuencia, numeroAnalista, 3, 1);
                        //    }
                        //}
                        //else
                        //{
                        //    if (SecDisponible == 0)
                        //    {
                        //        imagenesActivados = false;
                        //        swTiempoObs.Stop();
                        //        tmrProceso.Stop();
                        //    }
                        //    else if (cicloActual > cicloSec)
                        //    {
                        //        imagenesActivados = false;
                        //        swTiempoObs.Stop();
                        //        tmrProceso.Stop();
                        //        new SQL_Analista().UpdateStatusAnalista(idSecuencia, numeroAnalista, numero_estacion);
                        //        MessageBox.Show($"Se acabo el proceso de la estacion: {numero_estacion}");

                        //        if (backgroundWorker1.IsBusy != true)
                        //        {
                        //            // Start the asynchronous operation.
                        //            backgroundWorker1.RunWorkerAsync();
                        //        }
                        //    }
                        //}
                        #endregion
                    }
                    else if (numero_estacion == 3)///////////////////estacion 3///////////////////////////
                    {
                        SecDisponible = int.Parse(lblPzCola.Text);

                        //if ( (SecDisponible != 0) && (cicloActual < cicloSec)) // (SecDisponible != 0) && (cicloActual <= cicloSec)         cicloActual <= SecDisponible) && (cicloActual <= cicloSec
                        {
                            if (ProcesoActual < TPmenos)
                            {
                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);
                                swTiempoObs.Restart();

                                ProcesoActual++;
                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                            }
                            else
                            {
                                new SQL_Analista().UpdatePzColaMENOS(idSecuencia, numeroAnalista, numero_estacion, 1);

                                DataRow row = DT_tiempos.NewRow();
                                row[1] = ProcesoActual;
                                row[2] = $"{lblTseg.Text}.{lblTmilis.Text}";
                                row[3] = lblCicloAct.Text;
                                DT_tiempos.Rows.Add(row);

                                cicloActual++;

                                lblCicloAct.Text = cicloActual.ToString();
                                ProcesoActual = 0;
                                pzCola = pzCola - 1;
                                if (pzCola == 0)
                                {
                                    imagenesActivados = false;
                                    swTiempoObs.Reset();
                                    tmrProceso.Enabled = false;
                                }

                                pictureTarea.Image = new SQL_Operacion().byteArrayToImage((byte[])DTactividades.Rows[ProcesoActual][2]);
                                lblDescripcion.Text = DTactividades.Rows[ProcesoActual][1].ToString();
                            }
                        }
                    }
                }
                else { Console.WriteLine("ya no entra"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void finEstacion()
        {
            int finalizo = 0;
            int posi = 0;
            while (finalizo != 3)
            {
                try
                {
                    finalizo = new SQL_Practica().FinalizoEstAnterior(idSecuencia, posi, numeroAnalista);
                    if (finalizo == 3)
                    {
                        new SQL_Analista().GuardarPractica(DT_tiempos, idSecuencia, numero_estacion, numeroAnalista, horaInicio);

                        Invoke(new Action(() => MessageBox.Show("La sesion ha terminado")));

                        frmEvaluacionResult evaluacionResult = new frmEvaluacionResult(DT_tiempos, cicloSec, idSecuencia, idPract, numero_estacion, numeroAnalista, horaInicio);
                        Invoke(new Action(() => evaluacionResult.Show()));
                        Invoke(new Action(() => Close()));
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            tmrBuscaGrupo.Stop();
            tmrProceso.Stop();
            tmrRegresivo.Stop();
            tmrPzCola.Stop();
            backgroundWorker1.CancelAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        private void frmEjecucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrBuscaGrupo.Stop();
            tmrProceso.Stop();
            tmrRegresivo.Stop();
            tmrPzCola.Stop();
            backgroundWorker1.CancelAsync();
        }
    }
}
