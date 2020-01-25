using Design.DecoratorPattern.Components;

namespace Design.DecoratorPattern.Decorators
{
    public class AllWheelDrive : CarDecorator
    {
        public AllWheelDrive(ICar car) : base(car)
        {

        }

        public override double GetCost()
        {
            return 2000 + _car.GetCost();
        }
    }
}
