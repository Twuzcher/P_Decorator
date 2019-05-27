using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            description = this.beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.25 + beverage.cost();
        }
    }
}
