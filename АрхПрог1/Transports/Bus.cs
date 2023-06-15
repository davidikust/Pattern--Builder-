using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{    
    class Bus : LargeTransport
    {
        public Bus()
        {
            Payment = 0;
            Construct = new Construct();
            Driver = new Driver();
            Passangers = new PassangerArray();
            Others = new ArrayList();
        }
    
        public override void Add(Passanger passanger)
        {
            Passangers.Add(passanger);
        }

        
    }
}
