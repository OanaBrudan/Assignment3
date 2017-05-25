using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using ThirdAssignment.Models;

namespace ThirdAssignment.Providers
{
    public class SecretaryProvider
    {
        private static string connString;

        public SecretaryProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Secretary> RetrieveSecretary()
        {
            IList<Secretary> secretaryList = new List<Secretary>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM secretary";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Secretary secretary = new Secretary();
                        secretary.idsecretary = reader.GetInt32("idsecretary");
                        secretary.name = reader.GetString("name");
                        secretary.password = reader.GetString("password");

                        secretaryList.Add(secretary);
                    }
                }
            }

            return secretaryList;
        }

        public void AddSecretary(Secretary secretary)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO secretary(idsecretary, name, password) VALUES(@idsecretary, @name, @password)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idsecretary", secretary.idsecretary);
                cmd.Parameters.AddWithValue("@name", secretary.name);
                cmd.Parameters.AddWithValue("@password", secretary.password);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSecretary(Secretary secretary)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE secretary SET name = @name, password = @password WHERE idsecretary = @idsecretary;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idsecretary", secretary.idsecretary);
                cmd.Parameters.AddWithValue("@name", secretary.name);
                cmd.Parameters.AddWithValue("@password", secretary.password);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSecretary(int idsecretary)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM secretary WHERE idsecretary=@idsecretary";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idsecretary", idsecretary);

                cmd.ExecuteNonQuery();
            }
        }
    }
}