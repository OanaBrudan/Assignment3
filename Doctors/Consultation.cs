using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Consultation
    {
        public int id { get; set; }
        public String appointment { get; set; }
        public int doctor_id { get; set; }
        public int patient_identityCardNumber { get; set; }
    }
}
