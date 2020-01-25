using Design.DecoratorPattern.Components;

namespace Design.DecoratorPattern.Decorators
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Make => _car.Make;

        public abstract double GetCost();
    }
}
