using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10HW
{
    internal class Food
    {

        int fID;
        string foodName, foodDesc;
        double foodCost;


        public int FoodID
        {
            get { return fID; }
            set { fID = value; }

        }

        public string Name
        {
            get { return foodName; }
            set { foodName = value; }
        }

        public string Description
        {
            get { return foodDesc; }
            set { foodDesc = value; }
        }

        public double Cost
        {
            get { return foodCost;}
            set { foodCost = value; }
        }
    }
}
