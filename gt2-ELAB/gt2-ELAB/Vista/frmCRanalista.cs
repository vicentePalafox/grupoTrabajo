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

            reporte.SetParameterValue("NomProfesor", info.Profesor);
            reporte.SetParameterValue("NomMateria", info.Materia);
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


            DataTable procesos = info.Proceso;
            Funciones.DS_Operacion dsOper1 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper2 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper3 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper4 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper5 = new Funciones.DS_Operacion();

            string[] act1, act2, act3, act4, act5;

            switch (int.Parse(info.Ciclo))
            {
                case 1:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 0).Select(s => s.Field<string>("tOper")).ToArray();
                    dsOper1 = new Funciones.DS_Operacion();
                    dsOper1.DataTable1.Rows.Add(act1);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    break;
                case 2:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 0).Select(s => s.Field<string>("tOper")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 1).Select(s => s.Field<string>("tOper")).ToArray();
                    dsOper1.DataTable1.Rows.Add(act1);
                    dsOper2.DataTable1.Rows.Add(act2);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    break;
                case 3:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 0).Select(s => s.Field<string>("tOper")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 1).Select(s => s.Field<string>("tOper")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 2).Select(s => s.Field<string>("tOper")).ToArray();
                    dsOper1.DataTable1.Rows.Add(act1);
                    dsOper2.DataTable1.Rows.Add(act2);
                    dsOper3.DataTable1.Rows.Add(act3);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);
                    break;
                case 4:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 0).Select(s => s.Field<string>("tOper")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 1).Select(s => s.Field<string>("tOper")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 2).Select(s => s.Field<string>("tOper")).ToArray();
                    act4 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 3).Select(s => s.Field<string>("tOper")).ToArray();

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);
                    reporte.Subreports[3].SetDataSource(dsOper4);
                    break;
                case 5:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = false;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 0).Select(s => s.Field<string>("tOper")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 1).Select(s => s.Field<string>("tOper")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 2).Select(s => s.Field<string>("tOper")).ToArray();
                    act4 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 3).Select(s => s.Field<string>("tOper")).ToArray();
                    act5 = procesos.AsEnumerable().Where(s => s.Field<int>("ciclo") == 4).Select(s => s.Field<string>("tOper")).ToArray();

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);
                    reporte.Subreports[3].SetDataSource(dsOper4);
                    reporte.Subreports[4].SetDataSource(dsOper5);
                    break;
                default:
                    break;
            }

            crystalViewer.ReportSource = reporte;
        }
    }
}
