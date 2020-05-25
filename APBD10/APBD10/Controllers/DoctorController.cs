using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD10.DTOs.Req;
using APBD10.Models;
using APBD10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD10.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IPharmacyDbService _service;

        public DoctorController(IPharmacyDbService service)
        {
            this._service = service;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            var result = _service.GetDoctors();
            if (result != null)
                return Ok(result);
            return StatusCode(500);
        }
        [HttpPut]
        public IActionResult ModifyDoctor(DoctorRequest req)
        {
            _service.ModifyDoctor(req);
            //jak sprawdzić czy operacja na bazie się udała?
            return Ok();
        }
        [HttpPost]
        public IActionResult AddDoctor(DoctorRequest req)
        {
            _service.AddDoctor(req);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            _service.DleteDoctor(id);
            return Ok();
        }
    }
}