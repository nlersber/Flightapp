using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Repositories
{
    public class PersonnelRepository : IPersonnelRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Personnel> _stewards;

        public PersonnelRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _stewards = dbContext.Stewards;
        }

        public void Add(Personnel steward)
        {
            _stewards.Add(steward);
        }

        public void Delete(Personnel steward)
        {
            _stewards.Remove(steward);
        }

        public IEnumerable<Personnel> getAll()
        {
            return _stewards.ToList();
        }

        public Personnel getById(int id)
        {
            return _stewards.SingleOrDefault(s => s.PersonnelId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Personnel steward)
        {
            _stewards.Update(steward);
        }
    }
}
