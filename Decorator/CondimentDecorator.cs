﻿namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string description { get; }
    }
}