using Lab2.Interfaces;
using System.Collections.Generic;

namespace Lab2.Classes
{
    public class ItalianPizza : IPizza
    {
        readonly private string _pizzaName = "Italian";

        private List<object> _ingredients = new List<object>();

        public void Add(string ingredient)
        {
            this._ingredients.Add(ingredient);
        }

        public string ListIngredients()
        {
            string str = $"\nPizza's name: {_pizzaName}\nIngredients: ";

            for (int i = 0; i < this._ingredients.Count; i++)
            {
                str += this._ingredients[i] + ", ";
            }
            str = str.Remove(str.Length - 2);

            return $"{str}\n";
        }
    }
}