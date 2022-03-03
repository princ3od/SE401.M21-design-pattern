using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Transport
{
    internal class Ship : ITransport
    {
        public string deliver()
        {
            return "Deliver by sea in a container";
        }
    }
}
