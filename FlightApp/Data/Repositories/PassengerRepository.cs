using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly DbSet<Passenger> _passengers;
        private readonly ApplicationDbContext _context;

        public PassengerRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _passengers = dbContext.Passengers;
        }

        public void Add(Passenger passenger)
        {
            _passengers.Add(passenger);
        }

        public void Delete(Passenger passenger)
        {
            _passengers.Remove(passenger);
        }

        public IEnumerable<Passenger> getAll()
        {
            return _passengers.ToList();
        }

        public Passenger getById(int id)
        {
            return _passengers.SingleOrDefault(p => p.PassengerId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Passenger passenger)
        {
            _passengers.Update(passenger);
        }
    }
}
