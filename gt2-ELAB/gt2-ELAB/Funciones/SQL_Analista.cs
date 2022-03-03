using System;
using System.Configuration;
using System.Data;

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

        public bool DeleteAnalista(int idSec, int posiAnalista)
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
                    command.CommandText = "DeleteAnalista";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters.Add("@posi", MySqlDbType.Int32);

                    command.Parameters["@idSec"].Value = idSec;
                    command.Parameters["@posi"].Value = posiAnalista;

                    int exito = command.ExecuteNonQuery();
                    if (exito == 1)
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

        public void UpdatePzColaMENOS(int idSec, int posiAnalista, int posiEst, int pzCola)
        {
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdatePzColaMESOS";

                    cmd.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    cmd.Parameters.Add("@posiAnalista", MySqlDbType.Int32).Value = posiAnalista;
                    cmd.Parameters.Add("@posiEst", MySqlDbType.Int32).Value = posiEst;
                    cmd.Parameters.Add("@pzCola", MySqlDbType.Int32).Value = pzCola;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdatePzColaMAS(int idSec, int posiAnalista, int posiEst, int pzCola)
        {
            try
            {
                using(var conn =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd= new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdatePzColaMAS";

                    cmd.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    cmd.Parameters.Add("@posiAnalista", MySqlDbType.Int32).Value = posiAnalista;
                    cmd.Parameters.Add("@posiEst", MySqlDbType.Int32).Value = posiEst;
                    cmd.Parameters.Add("@pzCola", MySqlDbType.Int32).Value= pzCola;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertaPzCola(int idSec, int posiEst, int posiAnalista, int pzcola)
        {
            try
            {
                using (var conn =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CargarPZCola";

                    cmd.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    cmd.Parameters.Add("@posiAnalista", MySqlDbType.Int32).Value = posiAnalista;
                    cmd.Parameters.Add("@posiEst", MySqlDbType.Int32).Value = posiEst;
                    cmd.Parameters.Add("@pzCola", MySqlDbType.Int32).Value = pzcola;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
 
        public int BuscaPZcola(int idSec, int posiEstacion, int posiAnalista)
        {
            int result = 0;
            try
            {
                using(var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "BuscaPzCola";

                    command.Parameters.Add("@idSec", MySqlDbType.VarChar, 255);
                    command.Parameters["@idSec"].Value = idSec;

                    command.Parameters.Add("@posiEsta", MySqlDbType.Int32).Value = posiEstacion;
                    command.Parameters.Add("@posiAnalista", MySqlDbType.Int32).Value= posiAnalista;

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

        public bool UpdateStatusAnalista(int idSec, int posiAnalista, int posiEstacion)
        {
            bool result = false;
            try
            {
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "AnalistaFinalizo";

                    command.Parameters.Add("@idSec", MySqlDbType.Int32);
                    command.Parameters.Add("@posi", MySqlDbType.Int32);
                    command.Parameters.Add("@posiEst", MySqlDbType.Int32);

                    command.Parameters["@idSec"].Value = idSec;
                    command.Parameters["@posi"].Value = posiAnalista;
                    command.Parameters["@posiEst"].Value = posiEstacion;

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public bool GuardarPractica(DataTable dt, int idSec, int posiEst, int posiAnalista, string fechaInicio)
        {
            bool result;
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "InsertResultadosOper_post";

                    command.Parameters.Add("@nombre", MySqlDbType.VarChar, 255).Value = Entidad.Usuario.UsuarioName;
                    command.Parameters.Add("@idsec", MySqlDbType.Int32).Value = idSec;
                    command.Parameters.Add("@posiEstacion", MySqlDbType.Int32).Value = posiEst;
                    command.Parameters.Add("@posiAnalis", MySqlDbType.Int32).Value=posiAnalista;
                    command.Parameters.Add("@fecha", MySqlDbType.VarChar, 255).Value = fechaInicio;

                    command.Parameters.Add("@noOperacion", MySqlDbType.Int32);
                    command.Parameters.Add("@tObs", MySqlDbType.VarChar, 255);
                    foreach (DataRow row in dt.Rows)
                    {
                        command.Parameters["@noOperacion"].Value = row[1];
                        command.Parameters["@tObs"].Value = row[2].ToString();
                        command.ExecuteNonQuery();
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }

        public void GuardaConfigAnalisis(int noAnalista, int noEstacion, string t_obs,string t_nor, string t_est, string fecha, int idPrac, string destreza , string esfuerzo , string condicion , string concistencia, string tolerancia)
        {
            try
            {
                using(var conn =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AltaAjustePrac";

                    cmd.Parameters.Add("@usuarioAl", MySqlDbType.VarChar, 255).Value = Entidad.Usuario.UsuarioName;
                    cmd.Parameters.Add("@escuelaAl", MySqlDbType.VarChar, 255).Value = Entidad.Usuario.UsuarioEscuela;
                    cmd.Parameters.Add("@noAnalis", MySqlDbType.Int32).Value = noAnalista;
                    cmd.Parameters.Add("@noEstac", MySqlDbType.Int32).Value = noEstacion;
                    cmd.Parameters.Add("@tObs", MySqlDbType.VarChar, 100).Value = t_obs;
                    cmd.Parameters.Add("@tNor",MySqlDbType.VarChar, 100).Value = t_nor;
                    cmd.Parameters.Add("@tEst", MySqlDbType.VarChar, 100).Value=t_est;
                    cmd.Parameters.Add("@fecha", MySqlDbType.VarChar, 255).Value= fecha;
                    cmd.Parameters.Add("@idPrac", MySqlDbType.Int32).Value = idPrac;
                    cmd.Parameters.Add("@NoDestreza", MySqlDbType.VarChar, 100).Value = destreza;
                    cmd.Parameters.Add("@NoEsfuerzo", MySqlDbType.VarChar, 100).Value = esfuerzo;
                    cmd.Parameters.Add("@NoCondicion", MySqlDbType.VarChar, 100).Value = condicion;
                    cmd.Parameters.Add("@NoConcistencia", MySqlDbType.VarChar, 100).Value = concistencia;
                    cmd.Parameters.Add("@NoTolerancia", MySqlDbType.VarChar, 100).Value = tolerancia;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
