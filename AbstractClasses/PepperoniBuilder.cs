using Lab2.Classes;
using Lab2.Interfaces;
using System;

namespace Lab2.AbstractClasses
{

    public class PepperoniBuilder : IPizzaBuilder
    {

        private PepperoniPizza _pizza = new PepperoniPizza();

        public PepperoniBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new PepperoniPizza();
        }

     
        public void AddCheese()
        {
            this._pizza.Add("Cheese");
        }

        public void AddTomatoes()
        {
            this._pizza.Add("Tomatoes");
        }

        public void AddOlives()
        {
            //  this._pizza.Add("Olives");
            Console.WriteLine("You can't add Olives in Pepperoni");
        }

        public void AddMeat()
        {
            this._pizza.Add("Meat");
        }

        public IPizza GetPizza()
        {
            PepperoniPizza result = this._pizza;
            this.Reset();

            return result;
        }
    }
}