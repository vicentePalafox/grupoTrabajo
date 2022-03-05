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
    public partial class frmResultados : Form
    {
        int ciclosT;
        public frmResultados()
        {
            InitializeComponent();
        }

        public frmResultados(DataTable table, string fecha, int ciclo, int idPrac)
        {
            InitializeComponent();

            //Entidad.Secuencia secuencia = new Entidad.Secuencia();
            //new Funciones.SQL_Secuencia().BuscaSecuencia(idSec, out secuencia);

            lblAnalisis.Text = new Funciones.SQL_Practica().NombrePract_X_id(idPrac);
            lblResultados.Text = fecha;
            dgvMesa1.DataSource = cargaDGV(table, ciclosT); //table;
            ciclosT = ciclo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DataTable cargaDGV(DataTable table, int ciclo)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < ciclo; i++)
            {
                dt.Columns.Add($"ciclo{i + 1}").AllowDBNull = true;
            }

            try
            {
                var query = table.Select("máximo(noOper)");
                int num_alto = int.Parse(query[0].ToString());
                int numActual = 0;

                foreach (DataRow dr in table.Rows)
                {

                    for (int i = 0; i < num_alto; i++)
                    {
                        DataRow data = dt.NewRow();

                        
                        data[numActual] = table.Rows[2].ToString();
                    }
                    numActual++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return dt;
        }
    }
}
