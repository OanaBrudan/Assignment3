using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using ThirdAssignment.Models;

namespace ThirdAssignment.Providers
{
    public class DoctorProvider
    {
        private static string connString;

        public DoctorProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Doctor> RetrieveDoctor()
        {
            IList<Doctor> doctorList = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM doctor";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor();
                        doctor.iddoctor = reader.GetInt32("iddoctor");
                        doctor.name = reader.GetString("name");
                        doctor.password = reader.GetString("password");

                        doctorList.Add(doctor);
                    }
                }
            }

            return doctorList;
        }


        public void AddDoctor(Doctor doctor)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO doctor(iddoctor, name, password) VALUES(@iddoctor, @name, @password)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@iddoctor", doctor.iddoctor);
                cmd.Parameters.AddWithValue("@name", doctor.name);
                cmd.Parameters.AddWithValue("@password", doctor.password);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE doctor SET name = @name, password = @password WHERE iddoctor = @iddoctor;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@iddoctor", doctor.iddoctor);
                cmd.Parameters.AddWithValue("@name", doctor.name);
                cmd.Parameters.AddWithValue("@password", doctor.password);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM doctor WHERE iddoctor=@iddoctor";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@iddoctor", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}