using Lab2.Classes;
using Lab2.Interfaces;

namespace Lab2.AbstractClasses
{
    
    public class PizzaMaker : IPizzaBuilder
    {

        private Pizza _pizza = new Pizza("Custom");        

        public PizzaMaker()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza("Custom");
        }

        public void SetName(string str)
        {
            _pizza.SetName(str);
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
            this._pizza.Add("Meat");
        }
      
        public Pizza GetPizza()
        {
            Pizza result = this._pizza;
            this.Reset();

            return result;
        }
    }
}