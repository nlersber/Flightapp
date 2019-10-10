using FlightApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Orderline
    {
        #region Properties
        public int OrderLineId { get; set; }
        public DateTime Time { get; set; }
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public Category ProductCategory { get; set; }
        public int NumberOfProductItems { get; set; }
        public string ProductDescription { get; set; }
        public double TotalPrice => ProductPrice * NumberOfProductItems;
        #endregion
    }
}
