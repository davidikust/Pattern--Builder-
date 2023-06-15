using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    class Bike
    {
        public Construct Construct { get; set; }
        public Driver Driver { get; set; }
        public override string ToString()
        {
            string T = "-------------------------------\n" + 
                Construct.Type + "\n" +
                "Driver: " + Driver.Name +
                "\n-------------------------------\n\n\n";
            return T;
        }
    }
}
