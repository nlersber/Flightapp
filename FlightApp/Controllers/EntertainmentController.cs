using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApp.Data;
using FlightApp.Enums;
using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightApp.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class EntertainmentController : ControllerBase
    {
        private readonly IEntertainmentRepository _entertainmentRepository;

        public EntertainmentController(IEntertainmentRepository entertainmentRepository)
        {
            _entertainmentRepository = entertainmentRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Entertainment> GetAllEntertainment()
        {
            return _entertainmentRepository.getAll().ToList();
        }

        // GET: api/<controller>
        [HttpGet("/FindBy/{type}")]
        public IEnumerable<Entertainment> GetAllEntertainmentByType(EntertainmentType type)
        {
            return _entertainmentRepository.getAllPerType(type).ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Entertainment> Get(int id)
        {
            return _entertainmentRepository.getById(id);
        }
    }
}
