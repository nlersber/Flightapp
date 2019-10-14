using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Passenger
    {
        #region Fields
        private string _firstname;
        private string _lastname;
        private Seat _seat;
        #endregion

        #region Properties
        public int PassengerId { get; set; }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("please enter a firstname");
                _firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("please enter a lastname");
                _lastname = value;
            }
        }
        public PassengerGroup Group { get; set; }

        public Seat Seat
        {
            get
            {
                return _seat;
            }
            set
            {
                if (value.Equals(null))
                    throw new ArgumentException("select a seat for this passenger");
                _seat = value;
            }
        }
        public List<Orderline> Orders { get; set; }
        #endregion



        protected Passenger()
        {
            Orders = new List<Orderline>();
            //Group = new PassengerGroup();
        }

        public Passenger(string firstname, string lastname, Seat seat) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            Seat = seat;
        }
    }
}
