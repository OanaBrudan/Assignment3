using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ThirdAssignment.Models;
using ThirdAssignment.Providers;

namespace ThirdAssignment.Controllers
{
    [RoutePrefix("api/Admin")]
    public class AdminController : ApiController
    {
        DoctorProvider dp = new DoctorProvider();
        SecretaryProvider sp = new SecretaryProvider();

        //GET: api/Administrator/GetSecretary
        [Route("GetSecretary")]
        public IEnumerable<Secretary> GetSecretary()
        {
            return sp.RetrieveSecretary();
        }

        [Route("AddSecretary")]
        // POST: api/Administrator/AddSecretary
        public void PostSecretary([FromBody]Secretary value)
        {
            sp.AddSecretary(value);
        }

        [Route("UpdateSecretary")]
        //POST api/Administrator/UpdateSecretary
        public void PutSecretary([FromBody]Secretary value)
        {
            sp.UpdateSecretary(value);
        }

        [Route("DeleteSecretary/{id}")]
        //DELETE api/Administrator/DeleteSecretary
        public void DeleteSecretary(int id)
        {
            sp.DeleteSecretary(id);
        }

        //GET: api/Administrator/GetDoctor
        [Route("GetDoctor")]
        public IEnumerable<Doctor> Get()
        {
            return dp.RetrieveDoctor();
        }

        [Route("AddDoctor")]
        // POST: api/Administrator/AddDoctor
        public void Post([FromBody]Doctor value)
        {
            dp.AddDoctor(value);
        }

        [Route("UpdateDoctor")]
        //POST api/Administrator/UpdateDoctor
        public void Put([FromBody]Doctor value)
        {
            dp.UpdateDoctor(value);
        }

        [Route("DeleteDoctor/{id}")]
        //DELETE api/Administrator/DeleteDoctor
        public void DeleteDoctor(int id)
        {
            dp.DeleteDoctor(id);
        }
    }
}