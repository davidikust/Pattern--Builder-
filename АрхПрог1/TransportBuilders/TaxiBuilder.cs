using System;

namespace АрхПрог
{
    class ClassicTaxiBuilder : TransportBuilder
    {
        Taxi transport;
        public override TransportBuilder Reset()
        {
            transport = new Taxi();
            return this;
        }

        public override TransportBuilder SetConstract()
        {
            transport.Construct.Max = 4;
            transport.Construct.Type = "Classic Taxi";
            return this;
        }

        public override TransportBuilder SetDriver()
        {
            Random rand = new Random();
            transport.Driver.Name = Names.GetName(rand.Next());
            transport.Driver.Category = Category.B;
            return this;
        }

        public override TransportBuilder SetPayment()
        {
            transport.Payment = 60;
            return this;
        }

        public override TransportBuilder TakeOthers()
        {
            Taxi taxi = (Taxi)transport;
            if (!taxi.CheckAdult() && taxi.CheckCSS())
                transport.Others.Add(Others.CSS);
            return this;
        }

        public override TransportBuilder TakePassanger(Passanger passanger)
        {
            if (transport.Passangers.Count >= transport.Construct.Max)
            {
                throw new Exception("Device is full");
            }
            transport.Passangers.Add(passanger);            
            int payment = transport.Payment / transport.Passangers.Count;            
            for (int i = 0; i < transport.Passangers.Count; i++)
                transport.Passangers.Take(i).Pay(payment);
            
            return this;
        }

        public Taxi Get()
        {
            return transport;
        }
    }
}
