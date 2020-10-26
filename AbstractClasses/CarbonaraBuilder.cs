using Lab2.Classes;
using Lab2.Interfaces;
using System;

namespace Lab2.AbstractClasses
{

    public class CarbonaraBuilder : IPizzaBuilder
    {

        private CarbonaraPizza _pizza = new CarbonaraPizza();

        public CarbonaraBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new CarbonaraPizza();
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
            //   this._pizza.Add("Olives");
            Console.WriteLine("You can't add Olives in Carbonara");
        }

        public void AddMeat()
        {
            this._pizza.Add("Meat");
        }

        public object GetPizza()
        {
            var result = this._pizza;
            this.Reset();

            return result;
        }
    }
}