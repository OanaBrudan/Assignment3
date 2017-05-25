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

namespace Administrator
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void viewdoctor_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Admin/GetDoctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IEnumerable<Doctor>>().Result;
                dataGridViewDoctor.DataSource = doctors;
            }
        }

        private void deletedoctor_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Admin/DeleteDoctor/" + textdoctorid.Text).Result;
        }

        private void editdoctor_click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.id = Convert.ToInt32(textdoctorid.Text);
            doctor.name = textdoctorname.Text;
            doctor.password = textdoctorpassword.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Admin/UpdateDoctor", doctor).Result;
        }

        private void adddoctor_click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.id = Convert.ToInt32(textdoctorid.Text);
            doctor.name = textdoctorname.Text;
            doctor.password = textdoctorpassword.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Admin/AddDoctor", doctor).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void addsecretary_click(object sender, EventArgs e)
        {
            Secretary secretary = new Secretary();
            secretary.id = Convert.ToInt32(textsecretaryid.Text);
            secretary.name = textsecretaryname.Text;
            secretary.password = textsecretarypassword.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Admin/AddSecretary", secretary).Result;
        }

        private void editsecretary_click(object sender, EventArgs e)
        {

            Secretary secretary = new Secretary();
           

            secretary.id = Convert.ToInt32(textsecretaryid.Text);
            secretary.name = textsecretaryname.Text;
            secretary.password = textsecretarypassword.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Admin/UpdateSecretary", secretary).Result;
        }

        private void deletesecretary_click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Admin/DeleteSecretary/" + textsecretaryid.Text).Result;
        }

        private void viewsecretary_click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Admin/GetSecretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var secretaries = response.Content.ReadAsAsync<IEnumerable<Secretary>>().Result;
                dataGridViewSecretary.DataSource = secretaries;
            }
        }

        private void textsecretaryid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
