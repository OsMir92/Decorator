namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
