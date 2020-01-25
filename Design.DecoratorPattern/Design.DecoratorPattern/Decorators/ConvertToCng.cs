using Design.DecoratorPattern.Components;

namespace Design.DecoratorPattern.Decorators
{
    class ConvertToCng : CarDecorator
    {
        public ConvertToCng(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return 3000 + _car.GetCost();
        }
    }
}
