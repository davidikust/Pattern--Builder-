using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    class ClassicBusBuilder : TransportBuilder
    {
        Bus transport;

        public override TransportBuilder Reset()
        {
            transport = new Bus();
            return this;
        }

        public override TransportBuilder SetConstract()
        {
            transport.Construct.Max = 30;
            transport.Construct.Type = "ClassicBus";
            return this;
        }

        public override TransportBuilder SetDriver()
        {
            Random rand = new Random();
            transport.Driver.Name = Names.GetName(rand.Next());
            transport.Driver.Category = Category.C;
            return this;
        }

        public override TransportBuilder TakeOthers()
        {                      
            return this;
        }
        public override TransportBuilder SetPayment()
        {
            transport.Payment = 12;
            return this;
        }

        public override TransportBuilder TakePassanger(Passanger passanger)
        {
            if (transport.Passangers.Count >= transport.Construct.Max)
            {
                throw new Exception("Device is full");
            }

            int payment;
            payment = transport.Payment;

            if (passanger.Benefits)
                payment = payment / 2;

            if (!passanger.Adult)
                payment = payment / 2;

            if (passanger.Pay(payment))
                transport.Passangers.Add(passanger);
            else throw new Exception("Passanger have not enouth money");

            return this;
        }

        public Bus Get()
        {
            return transport;
        }


    }


















}
