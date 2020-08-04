using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    // simple factory
    /*
     
    public class Pizza
    {
        public void prepare()
        {

        }

        public void bake()
        {

        }

        public void cut()
        {

        }

        public void box()
        {

        }
    }

    public class CheesePizza : Pizza
    {

    }

    public class GreekPizza : Pizza
    {

    }

    public class PepperoniPizza : Pizza
    {

    }
    
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = new Pizza();

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("greek"))
                pizza = new GreekPizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();

            return pizza;
        }
    }

    public class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            
            return pizza;
        }
    }*/



    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Prepareing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for(int i = 0; i< toppings.Count; i++)
            {
                Console.WriteLine("  " + toppings[i]);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }
    }

    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Douth";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }

    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "--";
            sauce = "11";
            toppings.Add("22");
        }
    }

    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish and Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "gree";
            sauce = "xxx";
            toppings.Add("ggge");
        }
    }










    public abstract class PizzaStore
    {        
        // 프레임 웍으로 제공
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        // 변경 가능한 부분의 구현은 하위에서 한다.
        protected abstract Pizza createPizza(string type);
    }





    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza;
            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza;
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }


}
