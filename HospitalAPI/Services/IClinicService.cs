using HospitalAPI.Models;

namespace HospitalAPI.Services
{
    public interface IClinicService
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetAllClinics();
    }
}