using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class OrderController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderlineRepository _orderlineRepository;

        public OrderController(IProductRepository productRepository, IOrderlineRepository orderlineRepository)
        {
            _productRepository = productRepository;
            _orderlineRepository = orderlineRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Orderline> GetAll()
        {
            return _orderlineRepository.getAll().ToList().OrderBy(o=>o.TimeOfOrderPlacement).ThenByDescending(o=>o.OrderLineId);
        }

        // GET: api/<controller>
        [HttpGet("/GetLast20orders/")]
        public IEnumerable<Orderline> GetLast20ItemsOrdered()
        {
            return _orderlineRepository.getAll().ToList().OrderBy(o => o.TimeOfOrderPlacement).ThenByDescending(o => o.OrderLineId).Take(20);
        }

        // GET: api/<controller>
        [HttpGet("/GetOrdersFor/{passenger}")]
        public IEnumerable<Orderline> GetAllForSpecificPassenger(Passenger passenger)
        {
            return _orderlineRepository.getAllOrderFromSpecificCustomer(passenger).ToList().OrderBy(o=>o.TimeOfOrderPlacement).ThenByDescending(o=>o.OrderLineId);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult <Orderline> Get(int id)
        {
            return _orderlineRepository.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult <Orderline> Post(Orderline order)
        {
            _orderlineRepository.Add(order);
            _orderlineRepository.SaveChanges();
            return CreatedAtAction(nameof(Get), order.OrderLineId, order);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult<Orderline> Delete(int id)
        {
            Orderline line = _orderlineRepository.getById(id);
            _orderlineRepository.Delete(line);
            _orderlineRepository.SaveChanges();
            return line;
        }
    }
}
