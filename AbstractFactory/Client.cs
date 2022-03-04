using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new VictorianFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ModernFactory());
        }

        public void ClientMethod(IFactory factory)
        {
            var productA = factory.createTable();
            var productB = factory.createChair();

            Console.WriteLine(productB.hasLeg());
            Console.WriteLine(productB.sitOn());
            
        }
    }
}
