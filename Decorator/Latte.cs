namespace Decorator
{
    public class Latte : CondimentDecorator
    {
        Beverage beverage;

        public Latte(Beverage beverage) => this.beverage = beverage;

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }

        public override string description => $"{beverage.description}, Latte";
    }
}
