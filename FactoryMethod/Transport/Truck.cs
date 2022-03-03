using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Transport
{
    internal class Truck : ITransport
    {
        public string deliver()
        {
            return "Deliver by land in a box";
        }
    }
}
