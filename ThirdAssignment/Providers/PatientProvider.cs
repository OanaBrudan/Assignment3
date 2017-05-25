using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using ThirdAssignment.Models;

namespace ThirdAssignment.Providers
{
    public class PatientProvider
    {
        private static string connString;

        public PatientProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Patient> RetrievePatient()
        {
            IList<Patient> patientsList = new List<Patient>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM patient";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();
                      //  patient.id = reader.GetInt32("idpatient");
                        patient.name = reader.GetString("name");
                        patient.identitycardnumber = reader.GetInt32("identitycardnumber");
                        patient.personalnumericalcode = reader.GetString("personalnumericalcode");
                        patient.dateofbirth = reader.GetDateTime("dateofbirth");
                        patient.address = reader.GetString("address");

                        patientsList.Add(patient);
                    }
                }
            }

            return patientsList;
        }


        public void AddPatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO patient(name, identitycardnumber, personalnumericalcode, dateofbirth, address) VALUES( @name, @identitycardnumber , @personalnumericalcode, @dateofbirth, @address)";
                cmd.Prepare();

               // cmd.Parameters.AddWithValue("@idpatient", patient.id);
                cmd.Parameters.AddWithValue("@name", patient.name);
                cmd.Parameters.AddWithValue("@identitycardnumber", patient.identitycardnumber);
                cmd.Parameters.AddWithValue("@personalnumericalcode", patient.personalnumericalcode);
                cmd.Parameters.AddWithValue("@dateofbirth", patient.dateofbirth);
                cmd.Parameters.AddWithValue("@address", patient.address);


                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE patient SET name = @name, personalnumericalcode = @personalnumericalcode, dateofbirth = @dateofbirth, address = @address WHERE identitycardnumber = @identitycardnumber;";

                cmd.Prepare();

                //cmd.Parameters.AddWithValue("@idpatient", patient.id);
                cmd.Parameters.AddWithValue("@name", patient.name);
                cmd.Parameters.AddWithValue("@identitycardnumber", patient.identitycardnumber);
                cmd.Parameters.AddWithValue("@personalnumericalcode", patient.personalnumericalcode);
                cmd.Parameters.AddWithValue("@dateofbirth", patient.dateofbirth);
                cmd.Parameters.AddWithValue("@address", patient.address);

                cmd.ExecuteNonQuery();
            }
        }
    }
}