using Lab2.Interfaces;

namespace Lab1.Classes
{
    public class Cafe
    {
        private IPizzaBuilder _builder;

        public IPizzaBuilder Builder
        {
            set { _builder = value; }
        }

        public void makeMargarita()
        {
            this._builder.SetName("Margarita");
            this._builder.AddCheese();
            this._builder.AddTomatoes();
            this._builder.AddOlives();
        }

        public void makeCarbonara()
        {
            this._builder.SetName("Carbonara");
            this._builder.AddCheese();
            this._builder.AddTomatoes();
            this._builder.AddMeat();
        }
        public void makeItalian()
        {
            this._builder.SetName("Italian");
            this._builder.AddCheese();
            this._builder.AddTomatoes();
            this._builder.AddOlives();
            this._builder.AddMeat();
        }
        public void makePepperoni()
        {
            this._builder.SetName("Pepperoni");
            this._builder.AddCheese();
            this._builder.AddTomatoes();           
            this._builder.AddMeat();
        }
    }
}