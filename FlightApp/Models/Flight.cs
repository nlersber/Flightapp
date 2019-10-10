using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Flight
    {
        #region Properties
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
        public DateTime ETA { get; set; }
        public DateTime Duration { get; set; }
        public DateTime Date { get; set; }

        public List<Personnel> Personnel { get; set; }
        public List<Passenger> Passengers { get; set; }
        #endregion
    }
}
