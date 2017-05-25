using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSecretary
{
    public class Patient
    {
        public int id { get; set; }
        public int identityCardNumber { get; set; }
        public string name { get; set; }
        public string personalNumericalCode { get; set; }
        public string address { get; set; }
        public DateTime birthDate { get; set; }
    }
}
