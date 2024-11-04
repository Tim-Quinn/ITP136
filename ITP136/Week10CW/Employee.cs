using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10CW
{
    public class Employee
    {
        int empId;
        string fName, lName;

        public int EmployeeId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string lastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string firstName
        {
            get { return fName; }
            set { fName = value; }
        }


    }
}
