namespace Decorator
{
    public interface Drink
    {
        public string Order(ToppingType[] excludeToppingNames = null);
        public string OrderRemoveLastTopping();

    }
}