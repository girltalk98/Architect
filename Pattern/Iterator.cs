using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        double price;
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }
    }







    public class PancakeHouseMenu
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            addItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            addItem("Blueberry pancakes", "Pancakes made with fresh blueberries", true, 3.49);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public List<MenuItem> getMenuItems()
        {
            return menuItems;
        }

        // iterator pattern
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }

    public class DinerMenu
    {
        static int MAX_ITEMS = 2; int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegetarian BLT", "Bacon with Lettuce & tomato on whole wheat", true, 2.99);
            addItem("Soup of the Day", "Soup of the Day with potato salad", false, 3.29);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if(numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry menu is full! Can't add any more items");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }            
        }

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }


        // iterator pattern
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

    }








    public interface Iterator
    {
        bool hasNext();
        object next();
    }

    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= items.Length)
                return false;
            else
                return true;
        }
        
    }

    public class PancakeHouseMenuIterator : Iterator
    {
        List<MenuItem> items;
        int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= items.Count)
                return false;
            else
                return true;
        }

    }







    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("Menu\n-----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.WriteLine(menuItem.getName() + ", ");
            }
        }


    }



}
