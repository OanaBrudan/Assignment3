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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56083/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Admin/GetDoctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IList<Doctor>>().Result;

                for (int i = 0; i < doctors.Count; i++)
                {
                    if (doctors.ElementAt(i).name.Equals(textdoctorname.Text) && doctors.ElementAt(i).password.Equals(textdoctorpassword.Text))
                    {
                        DoctorF df = new DoctorF();
                        df.Show();
                    }
                }
            }
        
        }
    }
}
