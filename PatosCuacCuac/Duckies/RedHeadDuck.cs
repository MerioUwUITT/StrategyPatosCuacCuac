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
    internal class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Red Headed duck");
        }
    }
}
