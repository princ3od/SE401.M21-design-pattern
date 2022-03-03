using FactoryMethod.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogisticsFactory RoadLogisticsAtoB = new RoadLogistics();
            Console.WriteLine("Tuyen duong bo tu A den B chon 5 xe tai");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Xe tai thu {i}: {RoadLogisticsAtoB.createTransport().deliver()}");
            }
            ILogisticsFactory SeaLogisticsAtoB = new RoadLogistics();
            Console.WriteLine("Tuyen duong thuy tu A den B chon 5 tau");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Tau thu thu {i}: {SeaLogisticsAtoB.createTransport().deliver()}");
            }

            Console.ReadLine();
        }
    }
}
