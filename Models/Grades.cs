using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FINALU190274362HW4.Models
{
    public class Grades:Details
    {  // properties

        //encapsulation
        private string GradeAverage;
        private string Modulename;
        

        //constructor
        public Grades(string grade, string module)
        {
            GradeAverage = grade;
            Modulename = module;


        }

        // accessors

        public string _GradeAverage { get; set; }
        public string _Modulename { get; set; }

        //

        public void CalculateAverage()
        {

            var sumgrades = 0;
            var total = 0;
            // (module sum/ totalsum)*100
        }
        

    }
}