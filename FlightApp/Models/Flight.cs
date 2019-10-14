using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Flight
    {
        #region Fields
        private string _destination;
        private string _origin;
        private double _durationInMinutes;
        private DateTime? _date;
        #endregion


        #region Properties
        public int FlightId { get; set; }

        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("enter a destination");
                _destination = value;
            }

        }

        public string Origin
        {
            get
            {
                return _origin;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("enter the origin");
                _origin = value;
            }
        }

        public double Duration
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("set a durationtime please");
                _durationInMinutes = value;
            }
        }

        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value < DateTime.Now || !value.HasValue)
                    throw new ArgumentException("date cannot be set before now and had to be entered");
                _date = value;
            }
        }
        public DateTime ETA { get; set; }

        public List<Personnel> Personnel { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<PassengerGroup> PassengerGroups { get; set; }
        #endregion

        protected Flight()
        {
            Personnel = new List<Personnel>();
            Passengers = new List<Passenger>();
            PassengerGroups = new List<PassengerGroup>();
        }

        public Flight(string destination, string origin, double duration, DateTime date): this()
        {
            Destination = destination;
            Origin = origin;
            Duration = duration;
            Date = date;
            ETA = date.AddMinutes(duration);
        }
    }
}
