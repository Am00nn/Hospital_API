using HospitalAPI.Models;

namespace HospitalAPI.Repositories
{
    public interface IClinicRepository
    {
        void AddClinic(Clinic clinic);
        Clinic GetClinicById(int clinicId);
        IEnumerable<Clinic> GetClinics();
        void UpdateClinic(Clinic clinic);
    }
}