using gt2_ELAB.Entidad;

using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt2_ELAB.Funciones
{
    internal class SQL_Usuario
    {
        public SQL_Usuario()
        {

        }
        public bool Login(string user, string pass,out string nombre,out string escuela)
        {
             nombre = string.Empty;
             escuela = string.Empty;
            bool result = false;
            var conectionString = ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(conectionString);
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "Login";
                command.Parameters.Add("@user_name", MySqlDbType.VarChar, 255);
                command.Parameters["@user_name"].Direction = ParameterDirection.Input;
                command.Parameters.Add("@password_user", MySqlDbType.VarChar, 255);
                command.Parameters["@password_user"].Direction= ParameterDirection.Input;
                command.Parameters["@user_name"].Value = user;
                command.Parameters["@password_user"].Value = pass;
                MySqlDataReader reader = command.ExecuteReader();
                while  (reader.Read())
                {
                    result = true;
                    nombre = (string)reader[1];
                    escuela = (string)reader[7];
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
           
            return result;
        }

        //public string RecupPass(string user)
        //{

        //}

        
    }
}
