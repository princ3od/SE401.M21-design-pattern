using System;
using System.Collections.Generic;
namespace Strategy
{
    class Program
    {                  
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(100);
            Console.WriteLine("Enter month number between 1 and 12");
            var input = Console.ReadLine();
            int month = Convert.ToInt32(input);            
            IOfferStrategy strategy = context.GetStrategy(month);
            context.ApplyStrategy(strategy);
            Console.ReadLine();
        }
    }
}
