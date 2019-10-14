using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IPassengerRepository
    {
        Passenger getById(int id);
        IEnumerable<Passenger> getAll();
        void Add(Passenger passenger);
        void Update(Passenger passenger);
        void Delete(Passenger passenger);
        void SaveChanges();
    }
}
