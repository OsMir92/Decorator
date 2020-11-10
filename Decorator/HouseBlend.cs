namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
