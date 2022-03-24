using System.Linq;
namespace Decorator
{
    public class BubbleTopping : Topping
    {
        public BubbleTopping(Drink drink) : base(drink)
        {
            toppingName = ToppingType.Bubble;
        }

        public override string Order(ToppingType[] excludeToppingNames = null)
        {
            if (excludeToppingNames != null && excludeToppingNames.Contains(toppingName))
            {
                return _drink.Order(excludeToppingNames);
            }
            else
            {
                return _drink.Order(excludeToppingNames) + " + bubble";
            }
        }

    }
}