using HospitalAPI.Models;
using HospitalAPI.Repositories;

namespace HospitalAPI.Services
{
    public class AppointmentServices : IAppointmentServices
    {
        private readonly IBookingRepository _bookingRepository;

        private readonly IClinicRepository _clinicRepository;

        public AppointmentServices(IBookingRepository bookingRepository, IClinicRepository clinicRepository)
        {
            _bookingRepository = bookingRepository;


            _clinicRepository = clinicRepository;
        }

        public string AddBooking(Booking booking)
        {

            var clinic = _clinicRepository.GetClinicById(booking.ClinicId);

            if (clinic == null)
            {


                return "Clinic not found";



            }




            if (clinic.NumberOfSlots > 0)
            {

                clinic.NumberOfSlots -= 1;


                _clinicRepository.UpdateClinic(clinic);


                _bookingRepository.BookAppointment(booking);

                return $"Booking Successful. Slots remaining in clinic    : {clinic.NumberOfSlots} ";

            }


            return "No available slots in the clinic";
        }

        public IEnumerable<Booking> ViewAppointmentByClinic(int clinicId)
        {


            return _bookingRepository.ViewAppointmentByClinic(clinicId);


        }

        public IEnumerable<Booking> ViewAppointmentByPatient(int patientId)
        {


            return _bookingRepository.ViewAppointmentByPatient(patientId);


        }
    }
}
