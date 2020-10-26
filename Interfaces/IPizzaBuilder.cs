using Lab2.Classes;

namespace Lab2.Interfaces
{
    
    public interface IPizzaBuilder
    {       
        void Reset();
        void AddCheese();

        void AddTomatoes();

        void AddOlives();

        void AddMeat();

        IPizza GetPizza();
    }
}