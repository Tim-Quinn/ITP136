using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13HW
{
    public class Person
    {
        public Person(int idNum, string fullName, string address)
        {
            IDNumber = idNum;
            FullName = fullName;
            Addy = address;
        }

        public int IDNumber { get; set; }
        public string FullName { get; set; }
        public string Addy { get; set; }
    }
}
