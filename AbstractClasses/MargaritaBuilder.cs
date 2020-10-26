using Lab2.Classes;
using Lab2.Interfaces;
using System;

namespace Lab2.AbstractClasses
{

    public class MargaritaBuilder : IPizzaBuilder
    {

        private MargaritaPizza _pizza = new MargaritaPizza();

        public MargaritaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new MargaritaPizza();
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
            this._pizza.Add("Olives");
        }

        public void AddMeat()
        {
            //  this._pizza.Add("Meat");
            Console.WriteLine("You can't add Meat in Margarita");
        }
      
        public IPizza GetPizza()
        {
            MargaritaPizza result = this._pizza;
            this.Reset();

            return result;
        }
    }
}