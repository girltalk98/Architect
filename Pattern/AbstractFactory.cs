using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    // 이런식으로 재료 생성까지 더 추상화 한다!
    /*
    public interface PizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            throw new NotImplementedException();
        }

        public Clams createClam()
        {
            throw new NotImplementedException();
        }

        public Dough createDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni createPepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce createSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] createVeggies()
        {
            throw new NotImplementedException();
        }
    }*/

    /*
    public class UIToolkit
    {
        WidgetFactory wfactory;

        public UIToolkit(WidgetFactory wf)
        {
            this.wfactory = wf;
        }

        public void PopUpPrinterDialog()
        {
            // not! d = new Button(); -> createButton 으로 대리자가 생성하게 접근, 직접 생성 안한다!
            DialogWindow d = wfactory.createDialogWindow("Printer Setup");
            d.add(wfactory.createButton(OK_BUTTON));
            d.add(wfactory.createButton(Cancel_Button));
            d.showWindow();
        }
    }




    public class DriverForWinXP
    {
        WidgetFactory wf = new WinXPWidgetFactory();

        UIToolkit ui = new UIToolkit(wf);

    }

    */










}
