using Design.DecoratorPattern.Components;

namespace Design.DecoratorPattern.Decorators
{
    public class MoonRoof : CarDecorator
    {
        public MoonRoof(ICar car): base(car)
        {

        }

        public override double GetCost()
        {
            return 1000 + _car.GetCost();
        }
    }
}
