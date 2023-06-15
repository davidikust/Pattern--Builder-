using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{

    class Transport
    {
        public int Payment { get; set; }
        public Construct Construct { get; set; }
        public Driver Driver { get; set; }
        public PassangerArray Passangers { get; set; }
        public ArrayList Others { get; set; }
        public virtual void Add(Passanger passanger) { }
        public override string ToString()
        {
            string T = Construct.Type + "\n";
            T += Passangers.ToString();
            T += "-------------------------------\n";
            T += "End of " + Construct.Type + " list\n";
            T += "-------------------------------\n\n\n";
            return T;
        }
    }

    class LargeTransport : Transport
    {
        public override string ToString()
        {
            int i = 1;
            string T = "";
            T += "-------------------------------\n";
            T += "-------------------------------\n";
            T += Construct.Type + "\n";
            T += Passangers.ToString(1);          
            T += "-------------------------------\n";
            T += "End of " + Construct.Type + " list\n";
            T += "-------------------------------\n";
            T += "-------------------------------\n\n\n";
            return T;
        }
    }
}
