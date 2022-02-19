using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gt2_ELAB.Funciones
{
    internal class SQL_Analista
    {
        public SQL_Analista()
        {

        }

        public bool InsertAnalista(Entidad.Analista analista)
        {
            bool result = false;
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    conn.Open();
                    command.Connection = conn;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "AltaAnalista";

                    command.Parameters.Add("@username", MySqlDbType.VarChar, 200);
                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters.Add("@idEst", MySqlDbType.Int32);
                    command.Parameters.Add("@posi", MySqlDbType.Int32);

                    command.Parameters["@username"].Value = analista.usuario;
                    command.Parameters["@idSec"].Value = analista.idSecuencia;
                    command.Parameters["@idEst"].Value = analista.idEstacion;
                    command.Parameters["@posi"].Value = analista.posicionAnalista;

                    int alta = command.ExecuteNonQuery();

                    if (alta == 1)
                        result = true;
                    else
                        result = false;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }

    }
}
