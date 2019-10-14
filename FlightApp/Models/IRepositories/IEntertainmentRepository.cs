using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IEntertainmentRepository
    {
        Entertainment getById(int id);
        IEnumerable<Entertainment> getAll();
        void Add(Entertainment entertainment);
        void Update(Entertainment entertainment);
        void Delete(Entertainment entertainment);
        void SaveChanges();
    }
}
