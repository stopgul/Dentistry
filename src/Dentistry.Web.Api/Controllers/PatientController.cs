using Dentistry.Application.Patient;
using Dentistry.Core.Patient;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Dentistry.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("{id}")]
        public Patient Get(long id)
        {
            return _patientService.GetAll(); 
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
