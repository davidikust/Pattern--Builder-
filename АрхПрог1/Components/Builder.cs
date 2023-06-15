using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    enum Others { CSS }

    abstract class TransportBuilder
    {
        abstract public TransportBuilder Reset();
        abstract public TransportBuilder SetConstract();
        abstract public TransportBuilder SetDriver();
        abstract public TransportBuilder TakeOthers();
        abstract public TransportBuilder SetPayment();
        abstract public TransportBuilder TakePassanger(Passanger passanger);
        
    }
}
