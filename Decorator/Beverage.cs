namespace Decorator
{
    public abstract class Beverage
    {
        public virtual string description { get; protected set; } = "unknown beverage";

        public abstract double Cost();
    }
}