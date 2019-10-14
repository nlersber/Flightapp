using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IProductRepository
    {
        Product getById(int id);
        IEnumerable<Product> getAll();
        void Add(Product line);
        void Update(Product line);
        void Delete(Product line);
        void SaveChanges();
    }
}
