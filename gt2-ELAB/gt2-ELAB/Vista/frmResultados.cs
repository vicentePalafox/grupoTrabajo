using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace gt2_ELAB
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        public frmResultados(DataTable table, string fecha, int ciclo, int idPrac)
        {
            InitializeComponent();

            lblAnalisis.Text = new Funciones.SQL_Practica().NombrePract_X_id(idPrac);
            lblResultados.Text = fecha;
            dgvMesa1.DataSource = cargaDGV(table, ciclo);
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        public DataTable cargaDGV(DataTable table, int ciclo)
        {
            DataTable dt = new DataTable();

            try
            {
                var num_alto = table.Rows.Cast<DataRow>().Select(row => row.Field<int>("noOper")).Max();

                for (int i = 0; i <= num_alto; i++)
                {
                    dt.Columns.Add($"operacion: {i + 1}");
                    dt.Columns[i].AllowDBNull = true;
                }

                for (int i = 0; i <= ciclo; i++)
                {
                    string[] operaciones = table.AsEnumerable().Where(s => s.Field<int>("cicloT") == i).Select(s => s.Field<string>("tObservado")).ToArray();

                        DataRow dr = dt.NewRow();
                        dt.Rows.Add(operaciones);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                dt = null;
            }
            return dt;
        }
    }
}
