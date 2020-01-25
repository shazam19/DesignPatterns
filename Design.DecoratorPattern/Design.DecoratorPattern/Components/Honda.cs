using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern.Model
{
    public class Honda : ICar
    {
        public string Make => "Accord";

        public double GetCost()
        {
            return 80000;
        }
    }
}
