using gt2_ELAB.Entidad;

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
    public partial class frmEvaluacionResult : Form
    {
        int idConfig = 0;//se pide para actualizar calculos

        string fechaIni;
        decimal total;
        decimal destreza, esfuerzo, condicion, concistencia, tolerancia;
        int ciclo, idSec, idPrac, noEstacion, noAnalista, ciclos;
        bool insert = false;

        DataTable dtprocesos;
        public frmEvaluacionResult(DataTable table, int ciclo, int idSecuencia, int idPract, int noEstacion, int numeroAnalista, string fechaIni, int ciclos)
        {
            InitializeComponent();
            dtprocesos = table;
            this.ciclo = ciclo;
            idSec = idSecuencia;
            idPrac = idPract;
            this.noEstacion = noEstacion;
            this.noAnalista = numeroAnalista;
            this.fechaIni = fechaIni;
            this.ciclo=ciclos;
            insert = true;
        }

        public frmEvaluacionResult(DataTable table, string idConfig, int ciclos)
        {
            InitializeComponent();
            dtprocesos = table;
            this.idConfig =int.Parse(idConfig);
            this.ciclo = ciclos;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (!cbxDestreza.Text.Equals("") && !cbxEsfuerzo.Text.Equals("") && !cbxCondiciones.Text.Equals("") && !cbxConcistencia.Text.Equals(""))
            {
                decimal destreza = decimal.Parse(cbxDestreza.Text);
                decimal esfuerzo = decimal.Parse(cbxEsfuerzo.Text);
                decimal condicion = decimal.Parse(cbxCondiciones.Text);
                decimal concistencia = decimal.Parse(cbxConcistencia.Text);
                total = destreza + esfuerzo + condicion + concistencia;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal tObs = sumarTiempoObs(dtprocesos, ciclo);
            decimal evalDF = EvalDF();
            decimal tNor = EvalTnor(evalDF, tObs);
            decimal tEst = EvalTest(tNor);

            //inserta los valores
            if (insert)
                new Funciones.SQL_Analista().GuardaConfigAnalisis(noAnalista, noEstacion, tObs.ToString(), tNor.ToString(), tEst.ToString(), fechaIni, idPrac, destreza.ToString(), esfuerzo.ToString(), condicion.ToString(), concistencia.ToString(), tolerancia.ToString(), ciclo);
            else
                new Funciones.SQL_Analista().ActualizaConfigAnalisis(idConfig, tObs.ToString(), tNor.ToString(), tEst.ToString(), destreza.ToString(), esfuerzo.ToString(), condicion.ToString(), concistencia.ToString(), tolerancia.ToString());
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        public decimal sumarTiempoObs(DataTable table, int ciclo)
        {
            decimal resp;
            decimal suma = 0;
            try
            {
                foreach (DataRow item in table.Rows)
                {
                    suma += Decimal.Parse(item[2].ToString());
                }
                decimal tObs = suma / ciclo;

                resp = tObs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = 0;
            }
            return resp;
        }

        public decimal EvalDF()
        {
            //calcula suma de factores de desempeño
            decimal result = 0;
            destreza = Decimal.Parse(cbxDestreza.SelectedItem.ToString());
            esfuerzo = Decimal.Parse(cbxEsfuerzo.SelectedItem.ToString());
            condicion = Decimal.Parse(cbxCondiciones.SelectedItem.ToString());
            concistencia = Decimal.Parse(cbxConcistencia.SelectedItem.ToString());

            result = decimal.Parse(((destreza + esfuerzo + condicion + concistencia) + 1).ToString("N3"));
            return result;
        }

        public decimal EvalTnor(decimal fd, decimal tObs)
        {
            //calcula tiempo normal
            decimal result = 0;
            //calcula tiempo estandar
            result = decimal.Parse((tObs * fd).ToString("N3"));
            return result;
        }

        public decimal EvalTest(decimal tnor)
        {
            //calcula tiempo estandar
            tolerancia = decimal.Parse(cbxToleranciaS.SelectedItem.ToString());
            decimal result;

            result = decimal.Parse(((tolerancia + 1) * tnor).ToString("N3"));
            return result;
        }
    }
}
