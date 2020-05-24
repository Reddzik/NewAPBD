using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD10.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleDbContext _context;
        public PeopleController(PeopleDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_context.Persons.ToList());
        }
    }
}