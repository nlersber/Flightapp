using FlightApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Entertainment
    {
        #region Fields
        private string _title;
        private string _description;
        private EntertainmentType _entertainmentType;
        private string _genre;
        private double _durationInMinutes;
        #endregion

        #region Properties
        public int EntertainmentId { get; set; }

        public double Duration
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("please enter minutes for duration");
                _durationInMinutes = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("enter a title please");
                _title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("enter a title please");
                _description = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("enter a title please");
                _genre = value;
            }
        }

        public EntertainmentType EntertainmentType
        {
            get
            {
                return _entertainmentType;
            }
            set
            {
                if (value == EntertainmentType.Undefined)
                    throw new ArgumentException("please select a type");
                _entertainmentType = value;
            }
        }
        #endregion

        protected Entertainment()
        {

        }

        public Entertainment(string title, string description, string genre, EntertainmentType type, double duration) : this()
        {
            Title = title;
            Description = description;
            Genre = genre;
            EntertainmentType = type;
            Duration = duration;
        }
    }
}
