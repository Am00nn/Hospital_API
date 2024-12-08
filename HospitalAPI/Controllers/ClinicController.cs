﻿using HospitalAPI.Models;
using HospitalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("GetAllClinics")]
        public IActionResult GetAllClinics()
        {
            var clinics = _clinicService.GetAllClinics();

            return Ok(clinics);
        }

        [HttpPost("AddClinic")]

        public IActionResult AddClinic([FromBody] Clinic clinic)
        {

            clinic.NumberOfSlots = 20;

            _clinicService.AddClinic(clinic);

            return Ok("Clinic added successfully with 20 slots.");
        }

    }
}
