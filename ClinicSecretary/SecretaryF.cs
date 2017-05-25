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
using System.Net.Http.Formatting;

namespace ClinicSecretary
{
    public partial class SecretaryF : Form
    {
        public SecretaryF()
        {
            InitializeComponent();
        }

        private void btnaddpatient_click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

           
            patient.identityCardNumber = Convert.ToInt32(texticd.Text);
            patient.name = textpatientname.Text;
            patient.personalNumericalCode = textpnc.Text;
            patient.address = textpatientaddress.Text;
            patient.birthDate = dtpBirth.Value;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/AddPatient", patient).Result;
        }

        private void btneditpatient_click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.identityCardNumber = Convert.ToInt32(texticd.Text);
            patient.name = textpatientname.Text;
            patient.personalNumericalCode = textpnc.Text;
            patient.address = textpatientaddress.Text;
            patient.birthDate = dtpBirth.Value;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Secretary/EditPatient", patient).Result;
        }

        private void btnaddconsultation_click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(textconsultid.Text);
            consultation.appointment = textc.Text;
            consultation.doctor_id = Convert.ToInt32(textdoctorid.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(texticd1.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/AddConsultation", consultation).Result;
        }

        private void btneditconsultation_click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(textconsultid.Text);
            consultation.appointment = textc.Text;
            consultation.doctor_id = Convert.ToInt32(textdoctorid.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(texticd1.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/AddConsultation", consultation).Result;
        }

        private void btndeleteconsultation_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Secretary/DeleteConsultation/" + textconsultid.Text).Result;
        }

        private void btnviewconsultation_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Secretary/GetConsultation").Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridViewConsultation.DataSource = consultations;
            }
        }

        private void btnviewpatient_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Secretary/GetPatient").Result;

            if (response.IsSuccessStatusCode)
            {
                var patients = response.Content.ReadAsAsync<IEnumerable<Patient>>().Result;
                dataGridViewPatient.DataSource = patients;
            }
        }

        private void SecretaryF_Load(object sender, EventArgs e)
        {

        }

        private void textc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
