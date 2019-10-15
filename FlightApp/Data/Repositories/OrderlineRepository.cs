using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Repositories
{
    public class OrderlineRepository : IOrderlineRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<Orderline> _orders;

        public OrderlineRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _orders = dbContext.Orders;
        }

        public void Add(Orderline line)
        {
            _orders.Add(line);
        }

        public void Delete(Orderline line)
        {
            _orders.Remove(line);
        }

        public IEnumerable<Orderline> getAll()
        {
            return _orders.ToList();
        }

        public IEnumerable<Orderline> getAllOrderFromSpecificCustomer(Passenger passenger)
        {
            return _orders.Where(o => o.Passenger == passenger).ToList();
        }

        public Orderline getById(int id)
        {
            return _orders.SingleOrDefault(o => o.OrderLineId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Orderline line)
        {
            _context.Update(line);
        }
    }
}
