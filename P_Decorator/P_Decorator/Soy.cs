using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            description = this.beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.30 + beverage.cost();
        }
    }
}
