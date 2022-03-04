using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VictorianTable:ITable
    {
        public string useFullTableFunction()
        {
            return "Victorian table use-full function ";
        }
    }

    class ModernTable:ITable
    {
        public string useFullTableFunction()
        {
            return "Modern table use-full function ";
        }
    }
}
