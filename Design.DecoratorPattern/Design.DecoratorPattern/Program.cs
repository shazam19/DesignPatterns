using DesignPattern.DecoratorPattern.Client;
using System;

namespace Design.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();

            dealer.BuyCar();
        }
    }
}
