using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.DecoratorPattern.Model;

namespace DesignPattern.DecoratorPattern.ModelDecorator
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
