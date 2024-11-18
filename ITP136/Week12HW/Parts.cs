using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week12HW
{
    public class Parts
    {
        int pNum;
        double pCost;
        string pName, pDescription;

        public Parts(int partNum,  string partName, string partDescription, double partCost)
        {
            pNum = partNum;
            pCost = partCost;
            pName = partName;
            pDescription = partDescription;

        }

        public int PartNum
        {
            get { return pNum; }
            set { pNum = value; }
        }

        public string PartName
        {
            get { return pName; }
            set { pName = value; }
        }

        public string PartDescription
        {
            get { return pDescription; }
            set { pDescription = value; }
        }

        public double Cost
        {
            get { return pCost; }
            set { pCost = value; }
        }

                
            

    }
}
