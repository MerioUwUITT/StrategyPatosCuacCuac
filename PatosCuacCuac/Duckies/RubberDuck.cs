using PatosCuacCuac.Behaviors.Abstractions;
using PatosCuacCuac.Behaviors;
using PatosCuacCuac.Duckies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatosCuacCuac.Duckies
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }
    }
}
