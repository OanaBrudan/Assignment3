using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ThirdAssignment.Models;
using ThirdAssignment.Providers;

namespace ThirdAssignment.Controllers
{
    [RoutePrefix("api/Secretary")]
    public class SecretaryController : ApiController
    {
        // GET: Secretary
        SecretaryProvider sp = new SecretaryProvider();
        PatientProvider pp = new PatientProvider();
        ConsultationProvider cc = new ConsultationProvider();

        [Route("GetPatient")]
        public IEnumerable<Patient> Get()
        {
            return pp.RetrievePatient();
        }

        // POST: api/Secretary
        [Route("AddPatient")]
        public void Post([FromBody]Patient value)
        {
            pp.AddPatient(value);
        }

        // PUT: api/Secretary
        [Route("UpdatePatient")]
        public void Put([FromBody]Patient value)
        {
            pp.UpdatePatient(value);
        }

        [Route("GetConsultation")]
        public IEnumerable<Consultation> GetConsultation()
        {
            return cc.RetrieveConsultation();
        }

        // POST: api/Secretary/AddConsultation
        [Route("AddConsultation")]
        public void PostConsultation([FromBody]Consultation consultation)
        {
            cc.AddConsultation(consultation);
        }

        // PUT: api/Secretary/UpdateConsultation
        [Route("UpdateConsultation")]
        public void PutConsultation([FromBody]Consultation consultation)
        {
            cc.UpdateConsultation(consultation);
        }

        // DELETE: api/Secretary/DeleteConsultation
        [Route("DeleteConsultation/{id}")]
        public void DeleteConsultation(int id)
        {
            cc.DeleteConsultation(id);
        }
    }
}