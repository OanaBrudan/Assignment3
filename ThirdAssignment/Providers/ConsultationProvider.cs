using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using ThirdAssignment.Models;

namespace ThirdAssignment.Providers
{
    public class ConsultationProvider
    {
        private static string connString;

        public ConsultationProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Consultation> RetrieveConsultation()
        {
            IList<Consultation> consultationList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM consultation";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Consultation consultation = new Consultation();
                        consultation.idconsultation = reader.GetInt32("idconsultation");
                        consultation.appointment = reader.GetString("appointment");
                        consultation.iddoctor = reader.GetInt32("iddoctor");
                        consultation.nrpatient = reader.GetInt32("nrpatient");

                        consultationList.Add(consultation);
                    }
                }
            }

            return consultationList;
        }


        public void AddConsultation(Consultation consultation)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO consultation(idconsultation, iddoctor, nrpatient, appointment) VALUES(@idconsultation, @iddoctor, @nrpatient, @appointment)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idconsultation", consultation.idconsultation);
                cmd.Parameters.AddWithValue("@iddoctor", consultation.iddoctor);
                cmd.Parameters.AddWithValue("@nrpatient", consultation.nrpatient);
                cmd.Parameters.AddWithValue("@appointment", consultation.appointment);
                
               

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateConsultation(Consultation consultation)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE consultation SET  iddoctor = @iddoctor, nrpatient = @nrpatient, appointment = @appointment, WHERE idconsultation = @idconsultation;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idconsultation", consultation.idconsultation);
                cmd.Parameters.AddWithValue("@iddoctor", consultation.iddoctor);
                cmd.Parameters.AddWithValue("@nrpatient", consultation.nrpatient);
                cmd.Parameters.AddWithValue("@appointment", consultation.appointment);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteConsultation(int idconsultation)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM consultation WHERE idconsultation=@idconsultation";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idconsultation", idconsultation);

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Consultation> RetrieveConsultationByPatient(int nrpatient)
        {
            IList<Consultation> consultationList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM consultation WHERE nrpatient=\"" + nrpatient + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Consultation consultation = new Consultation();
                        consultation.idconsultation = reader.GetInt32("idconsultation");
                        consultation.iddoctor = reader.GetInt32("iddoctor");
                        consultation.nrpatient = reader.GetInt32("nrpatient");
                        consultation.appointment = reader.GetString("appointment");
                        consultationList.Add(consultation);
                    }
                }
            }

            return consultationList;

        }
    }
}