using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt2_ELAB.Funciones
{
    internal class SQL_Estacion
    {
        public SQL_Estacion()
        {

        }

        public DataTable ListaEstacion(int idSec)
        {
            DataTable result = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ListaEstacion";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters["@idSec"].Value = idSec;

                    MySqlDataReader reader = command.ExecuteReader();
                    result.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
