namespace Decorator
{
    public class MilkTea : Drink
    {
        public string Order(ToppingType[] toppingNames = null)
        {
            return "A milk tea";
        }
        public string OrderRemoveLastTopping()
        {
            return "A milk tea";
        }
    }
}