using Design.DecoratorPattern.Components;
using Design.DecoratorPattern.Decorators;
using System;

namespace Design.DecoratorPattern.Client
{
    class CarDealer
    {
        public void BuyCar()
        {
            ICar car = new Honda();
            PrintCarPrice(car);

            car = new SunRoof(car);
            PrintCarPrice(car);

            car = new ConvertToCng(car);
            PrintCarPrice(car);

            car = new AllWheelDrive(car);
            PrintCarPrice(car);
        }

        private void PrintCarPrice(ICar car)
        {
            Console.WriteLine($"type: {car.GetType().Name}");
            Console.WriteLine($"---- Car price: {car.GetCost()}");
            Console.WriteLine();
        }
    }
}
