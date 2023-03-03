using PatosCuacCuac.Behaviors;
using PatosCuacCuac.Duckies;
using System;
namespace PatosCuacCuac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuckie = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();

            ModelDuck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
            Console.ReadKey();
        }
    }
}