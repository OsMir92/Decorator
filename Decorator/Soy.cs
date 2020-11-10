namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage) => this.beverage = beverage;

        public override double Cost()
        {
            return beverage.Cost() + 0.40;
        }

        public override string description => $"{beverage.description}, Soy";
    }
}
