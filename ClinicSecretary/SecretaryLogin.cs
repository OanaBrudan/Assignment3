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

namespace ClinicSecretary
{
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Admin/GetSecretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var secretaries = response.Content.ReadAsAsync<IList<Secretary>>().Result;

                for (int i = 0; i < secretaries.Count; i++)
                {
                    if (secretaries.ElementAt(i).name.Equals(textsecretaryname.Text) && secretaries.ElementAt(i).password.Equals(textsecretarypassword.Text))
                    {
                        SecretaryF sf = new SecretaryF();
                        sf.Show();
                    }
                }
            }

        
        }
    }
}
