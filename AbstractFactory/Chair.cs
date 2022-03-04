using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VictorianChair:IChair
    {
        public string hasLeg()
        {
            return "Victorian chair has leg";
        }

        public string sitOn()
        {
            return "Victorian chair has sit on function";
        }
    }

    class ModernChair:IChair
    {
        public string hasLeg()
        {
            return "Modern chair has leg";
        }

        public string sitOn()
        {
            return "Modern chair has sit on function";
        }
    }
}
