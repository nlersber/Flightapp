using System.Collections.Generic;

namespace FlightApp.Models
{
    public class PassengerGroup
    {
        #region Properties
        public int PassenGroupId { get; set; }
        public List<Passenger>Passengers { get; set; }
        #endregion

        public PassengerGroup() 
        {
            Passengers = new List<Passenger>();
        }

    }
}