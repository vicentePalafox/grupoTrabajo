using gt2_ELAB.Entidad;

using System.Data;
using System.Linq;
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
            CargarReporte();
        }

        public void CargarReporte()
        {
            reporte = new CRAnalisis();
            int cicloT = int.Parse(info.Ciclo) + 1;
            
            DataTable procesos = info.Proceso;
            Funciones.DS_Operacion dsOper1 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper2 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper3 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper4 = new Funciones.DS_Operacion();
            Funciones.DS_Operacion dsOper5 = new Funciones.DS_Operacion();

            string[] act1, act2, act3, act4, act5;

            switch (cicloT)
            {
                case 1:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 0).Select(s => s.Field<string>("tObservado")).ToArray();
                    dsOper1 = new Funciones.DS_Operacion();
                    dsOper1.DataTable2.Rows.Add(act1);

                    reporte.Subreports[0].SetDataSource(dsOper1);

                    CargaParametros(reporte);

                    crystalViewer.ReportSource = reporte;
                    reporte.Refresh();
                    break;
                case 2:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 0).Select(s => s.Field<string>("tObservado")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 1).Select(s => s.Field<string>("tObservado")).ToArray();
                    dsOper1.DataTable2.Rows.Add(act1);
                    dsOper2.DataTable2.Rows.Add(act2);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);

                    CargaParametros(reporte);

                    crystalViewer.ReportSource = reporte;
                    reporte.Refresh();
                    break;
                case 3:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = true;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 0).Select(s => s.Field<string>("tObservado")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 1).Select(s => s.Field<string>("tObservado")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 2).Select(s => s.Field<string>("tObservado")).ToArray();
                    dsOper1.DataTable2.Rows.Add(act1);
                    dsOper2.DataTable2.Rows.Add(act2);
                    dsOper3.DataTable2.Rows.Add(act3);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);

                    CargaParametros(reporte);

                    crystalViewer.ReportSource = reporte;
                    reporte.Refresh();
                    break;
                case 4:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = true;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 0).Select(s => s.Field<string>("tObservado")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 1).Select(s => s.Field<string>("tObservado")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 2).Select(s => s.Field<string>("tObservado")).ToArray();
                    act4 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 3).Select(s => s.Field<string>("tObservado")).ToArray();
                    dsOper1.DataTable2.Rows.Add(act1);
                    dsOper2.DataTable2.Rows.Add(act2);
                    dsOper3.DataTable2.Rows.Add(act3);
                    dsOper4.DataTable2.Rows.Add(act4);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);
                    reporte.Subreports[3].SetDataSource(dsOper4);

                    CargaParametros(reporte);

                    crystalViewer.ReportSource = reporte;
                    reporte.Refresh();
                    break;
                case 5:
                    reporte.ReportFooterSection5.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection6.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection7.SectionFormat.EnableSuppress = false;
                    reporte.ReportFooterSection8.SectionFormat.EnableSuppress = false;

                    act1 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 0).Select(s => s.Field<string>("tObservado")).ToArray();
                    act2 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 1).Select(s => s.Field<string>("tObservado")).ToArray();
                    act3 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 2).Select(s => s.Field<string>("tObservado")).ToArray();
                    act4 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 3).Select(s => s.Field<string>("tObservado")).ToArray();
                    act5 = procesos.AsEnumerable().Where(s => s.Field<int>("cicloT") == 4).Select(s => s.Field<string>("tObservado")).ToArray();
                    dsOper1.DataTable2.Rows.Add(act1);
                    dsOper2.DataTable2.Rows.Add(act2);
                    dsOper3.DataTable2.Rows.Add(act3);
                    dsOper4.DataTable2.Rows.Add(act4);
                    dsOper5.DataTable2.Rows.Add(act5);

                    reporte.Subreports[0].SetDataSource(dsOper1);
                    reporte.Subreports[1].SetDataSource(dsOper2);
                    reporte.Subreports[2].SetDataSource(dsOper3);
                    reporte.Subreports[3].SetDataSource(dsOper4);
                    reporte.Subreports[4].SetDataSource(dsOper5);

                    CargaParametros(reporte);

                    crystalViewer.ReportSource = reporte;
                    reporte.Refresh();
                    break;
                default:
                    break;
            }
        }

        public void CargaParametros(CRAnalisis rAnalisis)
        {
            int cicloT = int.Parse(info.Ciclo) + 1;
            rAnalisis.SetParameterValue("NomProfesor", info.Profesor);
            rAnalisis.SetParameterValue("NomMateria", info.Materia);
            rAnalisis.SetParameterValue("NombrAn", info.NomAnalista);
            rAnalisis.SetParameterValue("NombrRe", info.NomResult);
            rAnalisis.SetParameterValue("Obser1", info.TObs1);
            rAnalisis.SetParameterValue("Obser2", info.TObs2);
            rAnalisis.SetParameterValue("Obser3", info.TObs3);
            rAnalisis.SetParameterValue("TNormal1", info.TNormal1);
            rAnalisis.SetParameterValue("TNormal2", info.TNormal2);
            rAnalisis.SetParameterValue("TNormal3", info.TNormal3);
            rAnalisis.SetParameterValue("TEstandar1", info.TEstandar1);
            rAnalisis.SetParameterValue("TEstandar2", info.TEstandar2);
            rAnalisis.SetParameterValue("TEstandar3", info.TEstandar3);
            rAnalisis.SetParameterValue("TTObser", info.TTObs);
            rAnalisis.SetParameterValue("TTNorm", info.TTNorm);
            rAnalisis.SetParameterValue("TTEst", info.TTEst);
            rAnalisis.SetParameterValue("Ciclos", cicloT);
            rAnalisis.SetParameterValue("Operacion", info.Operacion);
            rAnalisis.SetParameterValue("Ana1", info.NomAnalista);
            rAnalisis.SetParameterValue("Ope1", info.Operador);
            rAnalisis.SetParameterValue("Hab1", info.Hab1);
            rAnalisis.SetParameterValue("Cond1", info.Cond1);
            rAnalisis.SetParameterValue("Consis1", info.Consis1);
            rAnalisis.SetParameterValue("Esfuerzo1", info.Esfuerzo1);
            rAnalisis.SetParameterValue("Suple1", info.Suple1);
        }
    }
}
