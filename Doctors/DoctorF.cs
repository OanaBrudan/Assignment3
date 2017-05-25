using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Doctors
{
    public partial class DoctorF : Form
    {
        public DoctorF()
        {
            InitializeComponent();
        }

        private void btnaddconsult_click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(textconsultationid.Text);
            consultation.appointment = dtpAppoinment.Value;
            consultation.doctor_id = Convert.ToInt32(textconsultdoctorid.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(texticn.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Doctor/UpdateConsultation", consultation).Result;
        }

        private void btnviewconsult_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor/GetConsultation/" + texticn.Text).Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridViewConsult.DataSource = consultations;
            }
        }


        
        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsult.SelectedRows.Count > 0)
            {
                Consultation c = dataGridViewConsult.SelectedRows[0].DataBoundItem as Consultation;
                if (c != null)
                {
                    textconsultationid.Text = c.id.ToString();
                    dtpAppoinment.Text = c.appointment.ToString();
                    textconsultdoctorid.Text = c.doctor_id.ToString();
                    texticn.Text = c.patient_identityCardNumber.ToString();
                   

                }
            }
        }
    }
}
