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
        public void ChangeBuilder(IPizzaBuilder builder)
        {
            this._builder = builder;
        }
    }
}