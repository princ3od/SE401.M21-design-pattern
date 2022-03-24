namespace Decorator
{
    public class BlackTea : Drink
    {
        public string Order(ToppingType[] toppingNames = null)
        {
            return "A black tea";
        }
        public string OrderRemoveLastTopping()
        {
            return "A black tea";
        }
    }
}