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
    public partial class frmCRanalista : Form
    {
        Reporte info = new Reporte();
        CRAnalisis reporte;
        public frmCRanalista(Reporte Datoreporte)
        {
            InitializeComponent();
            info = Datoreporte;
        }

        public void CargarReporte()
        {
            reporte = new CRAnalisis();

            reporte.SetParameterValue("NomProfesor",info.Profesor);
            reporte.SetParameterValue("NomMateria",info.Materia);
            reporte.SetParameterValue("NombrAn", info.NomAnalista);
            reporte.SetParameterValue("NombrRe", info.NomResult);
            reporte.SetParameterValue("Obser1", info.TObs1);
            reporte.SetParameterValue("Obser2", info.TObs2);
            reporte.SetParameterValue("Obser3", info.TObs3);
            reporte.SetParameterValue("TNormal1", info.TNormal1);
            reporte.SetParameterValue("TNormal2", info.TNormal2);
            reporte.SetParameterValue("TNormal3", info.TNormal3);
            reporte.SetParameterValue("TEstandar1", info.TEstandar1);
            reporte.SetParameterValue("TEstandar2", info.TEstandar2);
            reporte.SetParameterValue("TEstandar3", info.TEstandar3);
            reporte.SetParameterValue("TTObser", info.TTObs);
            reporte.SetParameterValue("TTNorm", info.TTNorm);
            reporte.SetParameterValue("TTEst", info.TTEst);
            reporte.SetParameterValue("Ciclos", info.Ciclo);
            reporte.SetParameterValue("Operacion", info.Operacion);
            reporte.SetParameterValue("Ana1", info.NomAnalista);
            reporte.SetParameterValue("Ope1", info.Operador);
            reporte.SetParameterValue("Hab1", info.Hab1);
            reporte.SetParameterValue("Cond1", info.Cond1);
            reporte.SetParameterValue("Consis1", info.Consis1);
            reporte.SetParameterValue("Esfuerzo1", info.Esfuerzo1);
            reporte.SetParameterValue("Suple1", info.Suple1);

            crystalViewer.ReportSource = reporte;

        }
    }
}
