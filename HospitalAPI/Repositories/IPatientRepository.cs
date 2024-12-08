using HospitalAPI.Models;

namespace HospitalAPI.Repositories
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetPatients();
    }
}