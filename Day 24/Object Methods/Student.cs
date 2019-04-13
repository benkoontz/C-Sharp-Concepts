using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Student
    {
        // class attributes (blueprint)
        public string name;
        public string major;
        public double gpa;

        public Student(string name, string major, double gpa)
        {
            this.name = name; // title of the object is equal to the title they passed in
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasHonors()
        {
            if ( gpa >= 3.5)
                return true;
            else
                return false;
        }

    }
}
