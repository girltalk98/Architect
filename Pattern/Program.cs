using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoIterator();
            //DoTemplateMethod();
            //DoStrategy();
            //DoObserver();
            DoFactoryMethod();
        }

        static void DoFactoryMethod()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.getName());
        }

        static void DoIterator()
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.printMenu();
        }

        static void DoTemplateMethod()
        {
            CaffeinBeverage coffee = new Coffee();

            coffee.prepareRecipe();
        }

        static void DoObserver()
        {
            WeatherData weatherData = new WeatherData();

            CurrentconditionDisplay currentDisplay = new CurrentconditionDisplay(weatherData);
            StatisticsDisplay stasticsDisplay = new StatisticsDisplay(weatherData);
            ForcastDisplay forecastDisplay = new ForcastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(75, 33, 58.9f);
            weatherData.setMeasurements(31, 45, 34.7f);
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
