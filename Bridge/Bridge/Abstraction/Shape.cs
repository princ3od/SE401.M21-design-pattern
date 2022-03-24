using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        public Coloring color;
        public string GetColor()
        {
            return color.GetColor();
        }
    }
}
