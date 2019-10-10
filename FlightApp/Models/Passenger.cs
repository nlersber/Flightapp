using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Passenger
    {
        #region Properties
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Seat Seat { get; set; }
        public List<Orderline> Orders { get; set; }
        #endregion
    }
}
