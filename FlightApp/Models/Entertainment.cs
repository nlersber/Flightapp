using FlightApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Entertainment
    {
        #region Properties
        public string EntertainmentId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public EntertainmentType EntertainmentType { get; set; }
        public string Genre { get; set; }
        #endregion
    }
}
