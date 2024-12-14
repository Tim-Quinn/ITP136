using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PizzaSize : Pizza
    {
        public string Size { get; set; }

        
        public PizzaSize(string name, string size) : base(name)
        {
            Size = size;
        }
    }
}
