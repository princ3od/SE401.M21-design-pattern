namespace Decorator
{
    public abstract class Topping : Drink
    {
        protected Drink _drink;
        public ToppingType toppingName { get; set; }
        public Topping(Drink drink)
        {
            _drink = drink;
        }
        public abstract string Order(ToppingType[] toppingNames = null);
        public virtual string OrderRemoveLastTopping()
        {
            return _drink.Order();
        }

    }
    public enum ToppingType
    {
        Bubble, Pudding,
    }
}