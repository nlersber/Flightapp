using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IPersonnelRepository
    {
        Personnel getById(int id);
        IEnumerable<Personnel> getAll();
        void Add(Personnel steward);
        void Update(Personnel steward);
        void Delete(Personnel steward);
        void SaveChanges();
    }
}
