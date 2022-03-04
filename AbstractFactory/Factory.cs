using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VictorianFactory:IFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ITable createTable()
        {
            return new VictorianTable();
        }
    }

    class ModernFactory:IFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ITable createTable()
        {
            return new ModernTable();
        }
    }
}
