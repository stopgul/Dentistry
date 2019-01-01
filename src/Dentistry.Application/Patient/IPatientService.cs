using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dentistry.Application.Patient
{
    public interface IPatientService
    {
        Task<Core.Patient.Patient> GetPatientByIdAsync(long id);
        Task<IEnumerable<Core.Patient.Patient>> GetPatients();
        Task<IEnumerable<Core.Patient.Patient>> GetPatientsByNameAsync(string name);
        Task<int> CreatePatientAsync(Core.Patient.Patient patient);
        Task<int> UpdatePatientAsync(Core.Patient.Patient patient);
    }
}
