using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW
{
    public class Student : Person
    {
        public Student(int num, string fn, string addy, string major, string advisor) : base(num, fn, addy)
        {
            Major = major;
            Advisor = advisor;

        }
        public string Major { get; set; }
        public string Advisor { get; set; }


        

    }
}
