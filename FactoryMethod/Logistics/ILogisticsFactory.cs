using FactoryMethod.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Logistics
{
    internal interface ILogisticsFactory
    {
        ITransport createTransport();
    }
}
