using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IOrderlineRepository
    {
        Orderline getById(int id);
        IEnumerable<Orderline> getAll();
        void Add(Orderline line);
        void Update(Orderline line);
        void Delete(Orderline line);
        void SaveChanges();
    }
}
