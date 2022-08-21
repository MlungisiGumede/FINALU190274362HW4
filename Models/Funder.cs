using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FINALU190274362HW4.Models
{
    public class Funder : Details
    { //encapsulation
        private int Id;
        private string Fundername;
        private int Amount;


        //constructor
        public Funder(int id, string fundername,int amount)
        {
            Id = id;
            Fundername = fundername;
            Amount = amount;


        }

        // accessors

        public int _Id { get; set; }
        public string _Fundername { get; set; }
        public int _Amount { get; set; }


    }
}