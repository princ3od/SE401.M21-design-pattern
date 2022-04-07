using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuarterDiscountStrategy : IOfferStrategy
    {
        public string Name => nameof(QuarterDiscountStrategy);

        public double GetDiscountPercentage()
        {
            return 0.25;
        }
    }
}
