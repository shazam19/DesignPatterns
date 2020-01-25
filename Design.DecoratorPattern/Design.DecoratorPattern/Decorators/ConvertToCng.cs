using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.DecoratorPattern.Model;

namespace DesignPattern.DecoratorPattern.ModelDecorator
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
