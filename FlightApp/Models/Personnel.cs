using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Personnel
    {
        #region Fields
        private string _firstname;
        private string _lastname;
        private string _email;
        #endregion

        #region Properties
        public int PersonnelId { get; set; }

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


        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Een gebruiker moet een email hebben");
                else if (!Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                    throw new ArgumentException("Ongeldig email formaat");
                _email = value;
            }
        }
        #endregion

        protected Personnel()
        {

        }

        public Personnel(string firstname, string lastname, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }
    }
}
