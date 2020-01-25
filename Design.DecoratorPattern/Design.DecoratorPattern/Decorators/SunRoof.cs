using Design.DecoratorPattern.Components;

namespace Design.DecoratorPattern.Decorators
{
    public class SunRoof : CarDecorator
    {
        public SunRoof(ICar car): base(car)
        {

        }

        public override double GetCost()
        {
            return 1000 + _car.GetCost();
        }
    }
}
