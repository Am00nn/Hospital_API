﻿using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class Clinic
    {
        [Key]
        public int CID { get; set; }

        [Required]
        public string C_Name { get; set; }

        [Required]
        public string C_Specialization { get; set; }

        [Required]
        public int NumberOfSlots { get; set; } = 20;
    }
}
