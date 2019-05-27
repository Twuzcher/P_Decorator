using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            description = this.beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
      
    }
}
