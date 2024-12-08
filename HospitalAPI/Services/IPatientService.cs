using HospitalAPI.Models;

namespace HospitalAPI.Services
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        IEnumerable<Booking> GetPatientAppointments(int patientId);
    }
}