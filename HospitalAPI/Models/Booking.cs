using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class Booking
    {

        [Key]
        public int BookingId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int ClinicId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        public Patient? Patient { get; set; }
        public Clinic? Clinic { get; set; }



    }
}
