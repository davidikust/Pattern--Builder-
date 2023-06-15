using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    class Taxi : Transport
    {

        public Taxi()
        {
            Payment = 0;
            Construct = new Construct();
            Driver = new Driver();
            Passangers = new PassangerArray();
            Others = new ArrayList();
        }



        public bool CheckAdult()
        {
            bool adult = true;
            for (int i = 0; i < Passangers.Count; i++)
            { 
                adult = adult && Passangers.Take(i).Adult;
            }
            return adult;
        }

        public bool CheckCSS()
        {
            bool css = false;
            foreach (Others item in Others)
            {
                css = css || (item == АрхПрог.Others.CSS);
            }
            return css;
        }

        public override void Add(Passanger passanger)
        {                        
            Passangers.Add(passanger);
        }

        
    }
}
