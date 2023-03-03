using PatosCuacCuac.Behaviors;
using PatosCuacCuac.Behaviors.Abstractions;
using PatosCuacCuac.Duckies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatosCuacCuac.Duckies
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}
