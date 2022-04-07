using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyContext
    {
        double price;
        Dictionary<string, IOfferStrategy> strategyContext
            = new Dictionary<string, IOfferStrategy>();
        public StrategyContext(double price)
        {
            this.price = price;
            strategyContext.Add(nameof(NoDiscountStrategy),
                    new NoDiscountStrategy());
            strategyContext.Add(nameof(QuarterDiscountStrategy),
                    new QuarterDiscountStrategy());
        }

        public void ApplyStrategy(IOfferStrategy strategy)
        {
           
            Console.WriteLine("Original price:" + price);
            double finalPrice
                = price - (price * strategy.GetDiscountPercentage());
            Console.WriteLine("Price after discount:" + finalPrice);
        }

        public IOfferStrategy GetStrategy(int monthNo)
        {
            if (monthNo < 6)
            {
                return strategyContext[nameof(NoDiscountStrategy)];
            }
            else
            {
                return strategyContext[nameof(QuarterDiscountStrategy)];
            }
        }
    }
}
