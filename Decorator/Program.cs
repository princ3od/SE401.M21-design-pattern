using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink milkTea = new MilkTea();
            Drink blackTea = new BlackTea();

            Drink bubbleMilkTea = new BubbleTopping(milkTea);
            Drink puddingMilkTea = new PuddingTopping(milkTea);
            Drink mixToppingMilkTea = new PuddingTopping(bubbleMilkTea);

            Console.WriteLine(">> Non-topping");
            Console.WriteLine(milkTea.Order());
            Console.WriteLine(blackTea.Order());

            Console.WriteLine(">> Single topping");
            Console.WriteLine(bubbleMilkTea.Order());
            Console.WriteLine(puddingMilkTea.Order());

            Console.WriteLine(">> Mix topping");
            Console.WriteLine(mixToppingMilkTea.Order());

            blackTea = new BubbleTopping(new BubbleTopping(blackTea));
            Console.WriteLine(blackTea.Order());
        }
    }
}
