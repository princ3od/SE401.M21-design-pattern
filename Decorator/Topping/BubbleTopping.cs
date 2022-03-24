namespace Decorator
{
    public class BubbleTopping : Topping
    {
        public BubbleTopping(Drink drink) : base(drink) { }

        public override string Order()
        {
            return _drink.Order() + " + bubble";
        }
    }
}