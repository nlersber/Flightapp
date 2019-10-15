using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Seat
    {
        #region Properties
        public int SeatId { get; set; }
        public string SeatNumber { get; set; }
        public Passenger Passenger { get; set; }
        [ForeignKey("Passenger")]
        public int PassengerId { get; set; }
        #endregion

        protected Seat()
        {

        }

        public Seat(string nr, Passenger p):this()
        {
            SeatNumber = nr;
            Passenger = p;
        }

    }
}
