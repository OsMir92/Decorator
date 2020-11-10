namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage) => this.beverage = beverage;

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }

        public override string description => $"{beverage.description}, Mocha";
    }
}
