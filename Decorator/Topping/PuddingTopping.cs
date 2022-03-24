using System.Linq;
namespace Decorator
{
    public class PuddingTopping : Topping
    {
        public PuddingTopping(Drink drink) : base(drink)
        {
            toppingName = ToppingType.Pudding;
        }
        public override string Order(ToppingType[] toppingNames = null)
        {
            if (toppingNames != null && toppingNames.Contains(toppingName))
            {
                return _drink.Order(toppingNames);
            }
            else
            {
                return _drink.Order(toppingNames) + " + pudding";
            }
        }

    }
}