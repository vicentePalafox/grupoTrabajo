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

        public DataTable listaAnalisis(string nombre)
        {
            //SELECT tobs, tnor,test FROM `configanalisis` WHERE noAnalista = 1 AND escuela = 'ACK' AND fecha LIKE '03/03/2022 01%'
            //SELECT id, CONCAT((SELECT practica.nombrePractica FROM practica WHERE id = 5), ' - ', fecha) FROM configanalisis WHERE usuario ='vic'

            DataTable dt = new DataTable();
            try
            {
                using (var db = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "ListaAnalisisResults";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuarioAn", MySqlDbType.VarChar, 255).Value = nombre;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                dt = null;
            }
            return dt;
        }

        public bool SelecionaPractica(int idConfig, out int idPrac, out int noAnalista, out string escuela, out int noEst, out string fecha)
        {
            idPrac = 0;
            noAnalista = 0;
            escuela = string.Empty;
            noEst = 0;
            fecha = string.Empty;
            bool resp = false;
            try
            {
                using (var db = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "BuscaInfoTResult";
                    cmd.Parameters.Add("idConfig", MySqlDbType.Int32).Value = idConfig;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        idPrac = int.Parse(dr[0].ToString());
                        noAnalista = int.Parse(dr[1].ToString());
                        escuela = dr[2].ToString();
                        noEst = int.Parse(dr[3].ToString());
                        fecha = dr[4].ToString();
                    }
                    resp = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = false;
            }
            return resp;
        }

        public bool BuscaTiempoAnalistas(int noAnalista, int idPract, string escuela, string fechaIni, string fechaFin, out string tobs1, out string tobs2, out string tobs3, out string test1, out string test2, out string test3, out string tnor1, out string tnor2, out string tnor3)
        {
            bool resp = false;

            tobs1 = string.Empty;
            tobs2 = string.Empty;
            tobs3 = string.Empty;
            test1 = string.Empty;
            test2 = string.Empty;
            test3 = string.Empty;
            tnor1 = string.Empty;
            tnor2 = string.Empty;
            tnor3 = string.Empty;

            try
            {
                using (var db = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "BuscaTiemposAnalisis";

                    cmd.Parameters.Add("@noAnalista", MySqlDbType.Int32).Value = noAnalista;
                    cmd.Parameters.Add("@idPract", MySqlDbType.Int32).Value = idPract;
                    cmd.Parameters.Add("@escuelaAl", MySqlDbType.VarChar, 255).Value = escuela;
                    cmd.Parameters.Add("@fechaIni", MySqlDbType.VarChar, 255).Value = fechaIni;
                    cmd.Parameters.Add("@fechaFin", MySqlDbType.VarChar, 255).Value = fechaFin;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    tobs1 = dt.Rows[0][0].ToString();
                    tobs2 = dt.Rows[1][0].ToString();
                    tobs3 = dt.Rows[2][0].ToString();

                    tnor1 = dt.Rows[0][1].ToString();
                    tnor2 = dt.Rows[1][1].ToString();
                    tnor3 = dt.Rows[2][1].ToString();

                    test1 = dt.Rows[0][2].ToString();
                    test2 = dt.Rows[1][2].ToString();
                    test3 = dt.Rows[2][2].ToString();

                    resp = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = false;
            }
            return resp;
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
                    command.CommandType = CommandType.StoredProcedure;
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
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "UpdatePzColaMAS";

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

        public void InsertaPzCola(int idSec, int posiEst, int posiAnalista, int pzcola)
        {
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
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
                using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "BuscaPzCola";

                    command.Parameters.Add("@idSec", MySqlDbType.VarChar, 255);
                    command.Parameters["@idSec"].Value = idSec;

                    command.Parameters.Add("@posiEsta", MySqlDbType.Int32).Value = posiEstacion;
                    command.Parameters.Add("@posiAnalista", MySqlDbType.Int32).Value = posiAnalista;

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
                    command.Parameters.Add("@posiAnalis", MySqlDbType.Int32).Value = posiAnalista;
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

        public void GuardaConfigAnalisis(int noAnalista, int noEstacion, string t_obs, string t_nor, string t_est, string fecha, int idPrac, string destreza, string esfuerzo, string condicion, string concistencia, string tolerancia, int ciclos)
        {
            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
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
                    cmd.Parameters.Add("@tNor", MySqlDbType.VarChar, 100).Value = t_nor;
                    cmd.Parameters.Add("@tEst", MySqlDbType.VarChar, 100).Value = t_est;
                    cmd.Parameters.Add("@fecha", MySqlDbType.VarChar, 255).Value = fecha;
                    cmd.Parameters.Add("@idPrac", MySqlDbType.Int32).Value = idPrac;
                    cmd.Parameters.Add("@NoDestreza", MySqlDbType.VarChar, 100).Value = destreza;
                    cmd.Parameters.Add("@NoEsfuerzo", MySqlDbType.VarChar, 100).Value = esfuerzo;
                    cmd.Parameters.Add("@NoCondicion", MySqlDbType.VarChar, 100).Value = condicion;
                    cmd.Parameters.Add("@NoConcistencia", MySqlDbType.VarChar, 100).Value = concistencia;
                    cmd.Parameters.Add("@NoTolerancia", MySqlDbType.VarChar, 100).Value = tolerancia;
                    cmd.Parameters.Add("@cicloT", MySqlDbType.Int32).Value = ciclos;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ActualizaConfigAnalisis(int idConfig, string t_obs, string t_nor, string t_est, string destreza, string esfuerzo, string condicion, string concistencia, string tolerancia)
        {
            try
            {
                using(var conn =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateAjustePrac";

                    cmd.Parameters.Add("idconfig", MySqlDbType.Int32).Value = idConfig;
                    cmd.Parameters.Add("@tObs", MySqlDbType.VarChar, 100).Value = t_obs;
                    cmd.Parameters.Add("@tNor", MySqlDbType.VarChar, 100).Value = t_nor;
                    cmd.Parameters.Add("@tEst", MySqlDbType.VarChar, 100).Value = t_est;
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

        public bool EliminaAnalista_Ejecucion(string username, int idSec, int idEst, int posi, int posiEstacion)
        {
            bool resp = false;
            try
            {
                using (var db =new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString))
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = db;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LimpiarAnalistaUs";
                    cmd.Parameters.Add("@usuarioAl", MySqlDbType.VarChar, 255).Value = username;
                    cmd.Parameters.Add("@idSec", MySqlDbType.Int32).Value = idSec;
                    cmd.Parameters.Add("@idEst", MySqlDbType.Int32).Value = idEst;
                    cmd.Parameters.Add("@posi", MySqlDbType.Int32).Value = posi;
                    cmd.Parameters.Add("@posiEst", MySqlDbType.Int32).Value=posiEstacion;

                    int exito = cmd.ExecuteNonQuery();
                    if (exito > 0)
                        resp = true;
                    else
                        resp = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resp = false;
            }
            return resp;
        }
    
    }
}
