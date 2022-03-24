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

            Console.WriteLine("------------");
            Console.WriteLine(">> Non-topping");
            Console.WriteLine(milkTea.Order());
            Console.WriteLine(blackTea.Order());

            Console.WriteLine("------------");
            Console.WriteLine(">> Single topping");
            Console.WriteLine(bubbleMilkTea.Order());
            Console.WriteLine(puddingMilkTea.Order());

            Console.WriteLine("------------");
            Console.WriteLine(">> Mix topping");
            Console.WriteLine(mixToppingMilkTea.Order());

            Console.WriteLine("------------");
            Console.WriteLine(">> Remove topping");
            Console.WriteLine(mixToppingMilkTea.OrderRemoveLastTopping());


            Console.WriteLine("------------");
            blackTea = new PuddingTopping(new BubbleTopping(blackTea));
            Console.WriteLine(blackTea.Order());
            blackTea = new BlackTea();
            blackTea = new BubbleTopping(new PuddingTopping(blackTea));
            Console.WriteLine(blackTea.Order());
            Console.WriteLine("------------");
            Console.WriteLine(">> Remove pudding");
            Console.WriteLine(blackTea.Order(excludeToppingNames: new ToppingType[] { ToppingType.Pudding }));
        }
    }
}
