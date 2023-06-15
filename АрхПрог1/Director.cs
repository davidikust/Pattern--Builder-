using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    class Director
    {
        TransportBuilder Builder { get; set; }
        public PassangerArray PassangerArray { get; set; }

        public void SetServer(TransportBuilder builder)
        {
            Builder = builder;
        }    
        


        public TransportBuilder ServTransport()
        {
            Builder = Builder.Reset();
            Builder = Builder.SetConstract();
            Builder = Builder.SetDriver();
            Builder = Builder.SetPayment();

            int i = 0;
            while (true)
            {
                try
                {
                    Builder = Builder.TakePassanger(PassangerArray.Take(i));
                    i++;
                }
                catch (Exception)
                {
                    break;
                }                
            }
            PassangerArray.RemoveRange(0, i);


            Builder = Builder.TakeOthers();

            return Builder;
        }

    }
}
