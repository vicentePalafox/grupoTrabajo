using gt2_ELAB.Entidad;

using MySql.Data.MySqlClient;

using System;
using System.Configuration;
using System.Data;

namespace gt2_ELAB.Funciones
{
    internal class SQL_Practica
    {
        public SQL_Practica()
        {

        }

        public bool BuscaPractica(string nombre, out Practica practica)
        {
            practica = null;
            bool result;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "BuscaPractica";

                    command.Parameters.Add("@nomPractica", MySqlDbType.VarChar, 255).Value = nombre;
                    command.Parameters.Add("@escuela", MySqlDbType.VarChar, 255).Value = Usuario.UsuarioEscuela;

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        practica = new Practica()
                        {
                            nombrePractica = reader[0].ToString(),
                            idSecuencia = int.Parse(reader[1].ToString()),
                            ciclos = int.Parse(reader[2].ToString())
                        };
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                practica=null;
                result=false;
            }
            return result;
        }

        public string NombrePract_X_id(int idPract)
        {
            string result = string.Empty;
            try
            {
                using(var conn =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "BuscaPracticaXId";

                    command.Parameters.Add("@idP", MySqlDbType.Int32).Value = idPract;
                    MySqlDataReader reader =command.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = string.Empty;
            }
            return result;
        }

        public DataTable ListaPractica()
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
                    command.CommandText = "ListaPractica";

                    command.Parameters.Add("@escuelaUs", MySqlDbType.VarChar, 255).Value = Usuario.UsuarioEscuela;

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

        public int FinalizoEstAnterior(int idSec, int posi, int analistaAtras)
        {
            int result = 0;

            try
            {
                using(var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "estatusEstacionAnterior";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    command.Parameters.Add("@posiAnalist", MySqlDbType.Int32).Value = analistaAtras;

                    result = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            return result;
        }
    }
}
