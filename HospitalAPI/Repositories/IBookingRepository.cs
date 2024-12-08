using HospitalAPI.Models;

namespace HospitalAPI.Repositories
{
    public interface IBookingRepository
    {
        void BookAppointment(Booking B);
        IEnumerable<Booking> ViewAppointmentByClinic(int clinicId);
        IEnumerable<Booking> ViewAppointmentByPatient(int patientId);
    }
}