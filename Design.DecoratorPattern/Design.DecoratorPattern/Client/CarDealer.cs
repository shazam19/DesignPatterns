using DesignPattern.DecoratorPattern.Model;
using DesignPattern.DecoratorPattern.ModelDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern.Client
{
    class CarDealer
    {
        public void BuyCar()
        {
            ICar car = new Honda();
            PrintCarPrice(car);

            car = new MoonRoof(car);
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
