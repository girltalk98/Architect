using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;

        State state = soldOutState;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
        }

        public void insertQuarter()
        {
            state.insertQuater();
        }

        public void ejectQuarter()
        {

        }

        public void turnCrank()
        {

        }

        public void dispense()
        {

        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot ...");
            if (count != 0)
                count--;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }
    }


    public interface State
    {
        public void NoQuarterState(GumballMachine gumballMachine);
        public void insertQuater();
        public void ejectQuarter();
        public void turnCrank();
        public void dispense();
    }

    public class NoQuarterState : State
    {
        GumballMachine gumballMachine;
        
        public void dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Youhaven't inserted a quater");
        }

        public void insertQuater()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        void State.NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
    }
}
