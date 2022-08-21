using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FINALU190274362HW4.Models
{
    public class Address:Details
    {
        //encapsulation
        
        private string street;
        private string city;
        private string state;
        private string country ;
        private int postal;
        //constructor
        public Address(string Street, string City, int Postal, string Country, string State)
        {
            street = Street;
            city = City;
            postal = Postal;
            state = State;
            country = Country;

        }

        // accessors

        public string _street { get; set; }
        public string _city { get; set; }
        public string _state { get; set; }
        public string _country { get; set; }
        public string _postal { get; set; }
    }
}