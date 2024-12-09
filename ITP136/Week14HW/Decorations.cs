using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14HW
{
    class Decorations
    {

        public Decorations(string line)
        {
            var split = line.Split(',');
            DecorationsID = Convert.ToInt32(split[0]);
            DecorationsName = split[1];
        }

        public int DecorationsID { get; set; }
        public string DecorationsName { get; set; }
    }
}
