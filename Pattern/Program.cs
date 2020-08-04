using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStrategy();
        }

        static void DoStrategy()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavoir(new FlyRocketPowered());
            model.performFly();
        }

    }
}
