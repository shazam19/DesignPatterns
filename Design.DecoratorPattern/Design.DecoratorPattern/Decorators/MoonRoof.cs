using DesignPattern.DecoratorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern.ModelDecorator
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
