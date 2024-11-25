using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW
{
    public class Teacher : Person
    {
        public Teacher(int num, string fn, string addy, double sal, int yrs) : base(num, fn, addy)
        {
            Salary = sal;
            YearsOfService = yrs;

        }
        public double Salary { get; set; }
      

        public int YearsOfService { get; set; }
      
        



    }



}

