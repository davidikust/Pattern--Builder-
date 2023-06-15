using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace АрхПрог
{
    class PassangerArray : ArrayList
    {
        enum Index
        {
            Default, Order
        } 
        
        ArrayList passangers = new ArrayList();        

        public override int Add(object value)
        {            
            return passangers.Add((Passanger)value);
        }

        public override void RemoveRange(int index, int count)
        {
            passangers.RemoveRange(index, count);
        }

        public Passanger Take(int i)
        {
            return (Passanger)passangers[i];
        }

        public override int Count => passangers.Count;


        public override string ToString()
        {
            string T = "";
            foreach (object item in passangers)
            {
                T += item.ToString();
            }
            return T;

        }

        public string ToString(int index)
        {
            string T = "";

            switch (index)  {

                case (int)Index.Default: // Вывод по умолчанию
                    T += this.ToString();
                    return T;


                case (int)Index.Order: // Нумерование пассажиров по очередности заполнения массива начиная с 1-го пассажира
                    int i = 1;
                    foreach (object item in passangers)
                    {
                        T += "Passanger #" + i++ + "\n";
                        T += item.ToString();
                    }
                    return T;
                   

                default: throw new Exception("Wrong parametr: index");
            }
        }
    }
}
