using System.Threading.Tasks;

namespace Dentistry.Application.Patient
{
    public interface IPatientService
    {
        Task<Core.Patient.Patient> GetPatientByIdAsync(long id);
        Task<int> CreatePatientAsync(Core.Patient.Patient patient);
        Task<int> UpdatePatientAsync(Core.Patient.Patient patient);
    }
}
