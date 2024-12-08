using HospitalAPI.Models;
using HospitalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentServices _appointmentService;

        public AppointmentController(IAppointmentServices appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost("BookAppointment")]
        public IActionResult BookAppointment([FromBody] Booking booking)
        {
            _appointmentService.AddBooking(booking);
            return Ok("Booking successful");
        }

        [HttpGet("GetByClinic/{clinicId}")]
        public IActionResult GetByClinic(int clinicId)
        {
            var appointments = _appointmentService.ViewAppointmentByClinic(clinicId);
            return Ok(appointments);
        }

        [HttpGet("GetByPatient/{patientId}")]
        public IActionResult GetByPatient(int patientId)
        {
            var appointments = _appointmentService.ViewAppointmentByPatient(patientId);
            return Ok(appointments);
        }
    }
}
