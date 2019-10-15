using FlightApp.Enums;
using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Repositories
{
    public class EntertainmentRepository : IEntertainmentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Entertainment> _entertainment;

        public EntertainmentRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _entertainment = dbContext.Entertainment;
        }

        public void Add(Entertainment entertainment)
        {
            _entertainment.Add(entertainment);
        }

        public void Delete(Entertainment entertainment)
        {
            _entertainment.Remove(entertainment);
        }

        public IEnumerable<Entertainment> getAll()
        {
            return _entertainment.ToList();
        }

        public IEnumerable<Entertainment> getAllPerType(EntertainmentType type)
        {
            return _entertainment.Where(e => e.EntertainmentType == type).ToList();
        }

        public Entertainment getById(int id)
        {
            return _entertainment.SingleOrDefault(e => e.EntertainmentId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Entertainment entertainment)
        {
            _entertainment.Update(entertainment);
        }
    }
}
