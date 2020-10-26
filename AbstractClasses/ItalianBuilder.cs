using Lab2.Classes;
using Lab2.Interfaces;

namespace Lab2.AbstractClasses
{

    public class ItalianBuilder : IPizzaBuilder
    {

        private ItalianPizza _pizza = new ItalianPizza();

        public ItalianBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new ItalianPizza();
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

        public IPizza GetPizza()
        {
            ItalianPizza result = this._pizza;
            this.Reset();

            return result;
        }
    }
}