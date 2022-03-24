namespace Decorator
{
    public class PuddingTopping : Topping
    {
        public PuddingTopping(Drink drink) : base(drink) { }
        public override string Order()
        {
            return _drink.Order() + " + pudding";
        }
    }
}