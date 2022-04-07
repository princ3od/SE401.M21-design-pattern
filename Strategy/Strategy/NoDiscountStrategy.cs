using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NoDiscountStrategy : IOfferStrategy
    {
        public string Name => nameof(NoDiscountStrategy);

        public double GetDiscountPercentage()
        {
            return 0;
        }
    }
}
