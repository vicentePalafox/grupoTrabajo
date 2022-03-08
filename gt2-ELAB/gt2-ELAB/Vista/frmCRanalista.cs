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
        string profesor, materia;
        CRAnalisis reporte;
        public frmCRanalista(string profesor, string materia)
        {
            InitializeComponent();
            this.profesor = profesor;
            this.materia = materia;
        }

        public void CargarReporte()
        {
            reporte = new CRAnalisis();

            reporte.SetParameterValue("NomProfesor", profesor);
            reporte.SetParameterValue("NomMateria", materia);
            reporte.SetParameterValue("NombrAn", materia);
            reporte.SetParameterValue("NombrRe", materia);
            reporte.SetParameterValue("Obser1", materia);
            reporte.SetParameterValue("Obser2", materia);
            reporte.SetParameterValue("Obser3", materia);
            reporte.SetParameterValue("TNormal1", materia);
            reporte.SetParameterValue("TNormal2", materia);
            reporte.SetParameterValue("TNormal3", materia);
            reporte.SetParameterValue("TEstandar1", materia);
            reporte.SetParameterValue("TEstandar2", materia);
            reporte.SetParameterValue("TEstandar3", materia);
            reporte.SetParameterValue("TTObser", materia);
            reporte.SetParameterValue("TTNorm", materia);
            reporte.SetParameterValue("TTEst", materia);
            reporte.SetParameterValue("Ciclos", materia);
            reporte.SetParameterValue("Operacion", materia);
            reporte.SetParameterValue("Ana1", materia);
            reporte.SetParameterValue("Ope1", materia);
            reporte.SetParameterValue("Hab1", materia);
            reporte.SetParameterValue("Cond1", materia);
            reporte.SetParameterValue("Consis1", materia);
            reporte.SetParameterValue("Esfuerzo1", materia);
            reporte.SetParameterValue("Suple1", materia);

            crystalViewer.ReportSource = reporte;

        }
    }
}
