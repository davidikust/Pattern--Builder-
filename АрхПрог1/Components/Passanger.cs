using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
   
    class Passanger
    {
        static int maxMoney = 1000;
        static int minMoney = 30;
        public string Name { get; set; }
        public int Money { get; set; }
        public bool Benefits { get; set; }
        public bool Adult { get; set; }


        public Passanger(int money, bool benefits, bool adult)
        {
            
            Name = Names.GetName(Program.rand.Next());
            Money = money;
            Adult = adult;
            Benefits = benefits;
        }

        static bool RandomBool(Random rand)
        {            
            if (rand.Next(0,100) % 2 == 0) return false;
            return true;        
        }
        public Passanger()
        {
            Name = Names.GetName(Program.rand.Next());
            Money = Program.rand.Next(minMoney, maxMoney);
            Adult = RandomBool(Program.rand); ;
            Benefits = RandomBool(Program.rand);
        }


            public bool Pay(int payment)
        {
            if (Money < payment)
                return false;
            Money -= payment;
            return true;
        }


        public override string ToString()
        {
            return  "----------------------\n"
                  + "Name: " + Name + "\n"
                  + "Money: " + Money + "\n"
                  + "Benefits: " + Benefits + "\n"
                  + "Adult: " + Adult + "\n"
                  + "----------------------\n";
        }
    }
}
