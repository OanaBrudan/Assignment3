using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ThirdAssignment.Models;
using ThirdAssignment.Providers;

namespace ThirdAssignment.Controllers
{
    [RoutePrefix("api/Doctor")]
    public class DoctorController : ApiController
    {
        ConsultationProvider cp = new ConsultationProvider();

        //GET: api/Doctor/GetConsultation
        [Route("GetConsultation/{patient_identityCardNumber}")]
        public IEnumerable<Consultation> GetConsultation(int patient_identityCardNumber)
        {
            return cp.RetrieveConsultationByPatient(patient_identityCardNumber);
        }


        // PUT: api/Doctor/UpdateConsultation
        [Route("UpdateConsultation")]
        public void Put([FromBody]Consultation value)
        {
            cp.UpdateConsultation(value);
        }
    }
}