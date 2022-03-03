using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySqlX.XDevAPI.Common;

namespace gt2_ELAB.Funciones
{
    internal class SQL_Secuencia
    {
        public SQL_Secuencia()
        {

        }

        public int IdSec_X_Practica(int idPrac)
        {
            int result;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Id_Secuencias";

                    command.Parameters.Add("@idPrac", MySqlDbType.Int32);
                    command.Parameters["@idPrac"].Value = idPrac;

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                        result = reader.GetInt32(0);
                    else
                        result = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            return result;
        }

        public bool BuscaSecuencia(int idSec, out Entidad.Secuencia secuencia)
        {
            bool result = false;
            secuencia = null;

            try
            {
                using(var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "BuscaSecuencia";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters["@idSec"].Value=idSec;

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        secuencia = new Entidad.Secuencia()
                        {
                            nombre = reader.GetString(1),
                            noEstaciones = reader.GetInt32(3)
                        };
                        result = true;
                    }
                    else
                    {
                        secuencia = null;
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result =false;
            }
            return result;
        }

        public void ActualizaIniciaTAnalista1(int idSec)
        {
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateEstadoTEstacion1";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int buscaIniciaTAnalista1(int idSec)
        {
            int result = 0;
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ObtenerEstadoTEstacion1";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    result = Convert.ToInt32(command.ExecuteScalar());

                    //MySqlDataReader reader = command.ExecuteReader();
                    //if (reader.Read())
                    //    result = reader.GetInt32(0);
                    //else
                    //    result = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            return result;
        }

        public int ObtenerCupo(int idSec, int posi)
        {
            int result = 0;

            try
            {
                using(var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    conn.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ObtenerCupo2";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters.Add("@posi", MySqlDbType.Int32);
                    command.Parameters["@idSec"].Value = idSec;
                    command.Parameters["@posi"].Value = posi;

                    MySqlDataReader reader =command.ExecuteReader();
                    if (reader.Read())
                        result = reader.GetInt32(0);
                    else
                        result = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }
            return result;
        }

        public bool DescontarCupo(int idEst, int lugar)
        {
            bool result = false;
            try
            {
                using(var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    var command = new MySqlCommand();
                    conn.Open();
                    command.Connection=conn;

                    command.CommandType=CommandType.StoredProcedure;
                    command.CommandText = "DescontarCupo";

                    command.Parameters.Add("@idEst", MySqlDbType.Int32);
                    command.Parameters.Add("@lugar", MySqlDbType.Int32);
                    command.Parameters["@idEst"].Value = idEst;
                    command.Parameters["@lugar"].Value = lugar;
                    int update = command.ExecuteNonQuery();
                    if(update == 1)
                        result= true;
                    else
                        result= false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result= false;
            }
            return result;
        }

        
    }
}
