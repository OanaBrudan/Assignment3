using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdAssignment.Models
{
    public class Patient
    {
        public int id { get; set; }
        public int identitycardnumber { get; set; }
        public string name { get; set; }
        public string personalnumericalcode { get; set; }
        public string address { get; set; }
        public DateTime dateofbirth { get; set; }
    }
}