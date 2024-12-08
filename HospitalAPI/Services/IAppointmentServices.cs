using HospitalAPI.Models;

namespace HospitalAPI.Services
{
    public interface IAppointmentServices
    {
        string AddBooking(Booking booking);
        IEnumerable<Booking> ViewAppointmentByClinic(int clinicId);
        IEnumerable<Booking> ViewAppointmentByPatient(int patientId);
    }
}