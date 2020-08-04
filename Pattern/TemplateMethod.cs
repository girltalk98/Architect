using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public abstract class CaffeinBeverage
    {
        // 템플리 메소드 부분 (이부분은 하위에서 수정을 못하도록!)
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            
            // 후크!
            if(customerWantsCondiments())
                addCondiments();

        }

        public abstract void brew();
        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }






    public class Coffee : CaffeinBeverage
    {        
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {
            // string answer = getUserInput();
            // if(answer == "yes")
            //     return true;
            // else
            return true;
        }
    }

    public class Tea : CaffeinBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

    }



}
