using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying!!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }




    public interface QuckBehavior
    {
        public void quack();
    }

    public class Quack : QuckBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : QuckBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : QuckBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }







    public abstract class Duck
    {
        // composition 오브젝트
        public FlyBehavior flyBehavior;
        public QuckBehavior quackBehavoir;

        public Duck()
        {

        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();  // 델리게이션
        }

        public void performQuack()
        {
            quackBehavoir.quack();  // 델리게이션
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehavoir(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuckBehavior qb)
        {
            quackBehavoir = qb;
        }

    }







    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavoir = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavoir = new Quack();
            flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }


}
