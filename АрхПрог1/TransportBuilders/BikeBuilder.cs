using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    class BikeBuilder : TransportBuilder
    {
        protected Bike transport;
        public override TransportBuilder Reset()
        {
            transport = new Bike();
            return this;
        }

        public override TransportBuilder SetConstract()
        {
            transport.Construct = new Construct();
            transport.Construct.Max = 1;
            transport.Construct.Type = "ClassicBike";
            return this;
        }

        public override TransportBuilder SetDriver()
        {
            Random rand = new Random();
            transport.Driver = new Driver();
            transport.Driver.Name = Names.GetName(rand.Next());
            transport.Driver.Category = Category.A;
            return this;
        }

        public override TransportBuilder TakeOthers()
        {                      
            return this;
        }
        public override TransportBuilder SetPayment()
        {
            return this;
        }

        public override TransportBuilder TakePassanger(Passanger passanger)
        {
            return this;
        }

        public Bike Get()
        {
            return transport;
        }
    }


















}
