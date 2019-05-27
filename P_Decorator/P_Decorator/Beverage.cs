using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
