﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models.IRepositories
{
    public interface IProductRepository
    {
        Product getById(int id);
        IEnumerable<Product> getAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void SaveChanges();
    }
}
