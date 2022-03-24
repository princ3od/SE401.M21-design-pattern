namespace Decorator
{
    public abstract class Topping : Drink
    {
        protected Drink _drink;
        public Topping(Drink drink)
        {
            _drink = drink;
        }
        public override string Order()
        {
            return _drink.Order();
        }
    }
}