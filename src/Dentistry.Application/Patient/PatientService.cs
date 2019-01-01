using Dentistry.EntityFramework.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dentistry.Application.Patient
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Core.Patient.Patient> _patientRepository;
        //private readonly IMapper _mapper;

        public PatientService(IRepository<Core.Patient.Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }
        //public PatientService(IRepository<Core.Patient.Patient> patientRepository, IMapper mapper)
        //public PatientService( IMapper mapper)
        //{
        //   // _patientRepository = patientRepository;
        //    _mapper = mapper;
        //}

        public async Task<Core.Patient.Patient> GetPatientByIdAsync(long id)
        {
            return await _patientRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Core.Patient.Patient>> GetPatientsByNameAsync(string name)
        {
            return await _patientRepository.GetByConditionAsync(t=>t.Name==name);
        }

        public async Task<IEnumerable<Core.Patient.Patient>> GetPatients()
        {            
            return await _patientRepository.GetAllAsync();
        }

        public async Task<int> CreatePatientAsync(Core.Patient.Patient patient)
        {
            return await _patientRepository.AddAsync(patient);
        }

        public async Task<int> UpdatePatientAsync(Core.Patient.Patient patient)
        {
            return await _patientRepository.UpdateAsync(patient);
        }
    }
}
