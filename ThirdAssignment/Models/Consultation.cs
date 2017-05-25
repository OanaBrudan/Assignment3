using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdAssignment.Models
{
    public class Consultation
    {
        public int idconsultation { get; set; }
        public String appointment { get; set; }
        public int iddoctor { get; set; }
        public int nrpatient { get; set; }
    }
}