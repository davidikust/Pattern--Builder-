using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    enum Category { A, B, C }
    
    static class Program
    {
        public static Random rand = new Random();
        static void Main()
        {
            Director director = new Director();
            ClassicBusBuilder busBuilder = new ClassicBusBuilder();
            ClassicTaxiBuilder taxiBuilder = new ClassicTaxiBuilder();
            BikeBuilder bikeBuilder = new BikeBuilder();

            ArrayList devices = new ArrayList();
            Random random = new Random();



            Console.Write("Введите количество пассажиров:  ");
            int amount = Convert.ToInt32(Console.ReadLine());
            director.PassangerArray = new PassangerArray();
            for (int i = 0; i < amount; i++)
            {
                director.PassangerArray.Add(new Passanger());
            }            
                        
            while (director.PassangerArray.Count > 0)
            {
                Console.WriteLine("Имеется " + director.PassangerArray.Count + " пассажиров.");
                Console.WriteLine("Выберите способ отправки:");
                Console.WriteLine("1 - Автобус");
                Console.WriteLine("2 - Такси");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        director.SetServer(busBuilder);
                        busBuilder = (ClassicBusBuilder)director.ServTransport();
                        devices.Add(busBuilder.Get());
                        break;

                    case 2:
                        director.SetServer(taxiBuilder);
                        taxiBuilder = (ClassicTaxiBuilder)director.ServTransport();
                        devices.Add(taxiBuilder.Get());
                        break;

                    default:
                        Console.WriteLine("Try again");
                        break;
                }
                
            }
            foreach (object item in devices)
            {
                Console.WriteLine(item.ToString());
            }

            


            Console.WriteLine("\n\n Программа завершена");
            Console.ReadKey();
        }
    }
}
