using Dentistry.Application.Patient;
using Dentistry.EntityFramework.Repositories;
using Dentistry.Test.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Dentistry.Application.Test
{
    public class PatientServiceTests : TestBase
    {
        private readonly IPatientService _patientService;

        public PatientServiceTests()
        {
            var patientRepository = new Repository<Core.Patient.Patient>(DentistryInMemoryContext);
            _patientService = new PatientService(patientRepository);//, Mapper
        }

        [Fact]
        public void Create_And_Get_Patients()
        {
            IEnumerable<Core.Patient.Patient> patientList = _patientService.GetPatients().Result;
            Assert.True(patientList.Count() >= 0);

            Core.Patient.Patient patient = new Core.Patient.Patient();
            patient.Name = "John Test Test1";
            patient.PhoneNumber = "8623452673";
            patient.Address = "300 N Kendall Rd";
            var result = _patientService.CreatePatientAsync(patient);

            patientList = _patientService.GetPatientsByNameAsync(patient.Name).Result;
            Assert.True(patientList.Count() >= 1);
        }
    }
}
