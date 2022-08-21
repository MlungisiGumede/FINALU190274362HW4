using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FINALU190274362HW4.Models
{
    public class Student:Details
    {
        //encapsulation

        // properties
        private string Name;
        private  string Surname;
        private string Email;
        private int IDnumber;
        private int Amount;
        private string Funder;
        private double Grade;
        private string Degree;




        //constructor
        public Student(string name,string surname,string email,int id,int amount,string funder,double grade,string degree)
        {

            Name = name;
            Surname = surname;
            Email = email;
            IDnumber = id;
            Amount = amount;
            Funder = funder;
            Grade = grade;
            Degree = degree;
        }

        // accessors
    /*    public string _Name {
     *    {get return Name;}
     *    
     *    {set value = name;}
     *    
     *    return the values
     *    
     *    }*/




        public string _Name { get; set; }

        public string _Surname { get; set; }

        public string _Email { get; set; }

        public string _ID { get; set; }

        public string _Funder { get; set; }

        public string _Grade { get; set; }

        public string _Degree { get ; set; }

        // method

        //stored in my Details, polymorphism
    }
}