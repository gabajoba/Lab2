namespace Lab2.Interfaces
{
    
    public interface IPizzaBuilder
    {
        void SetName(string str);
        void AddCheese();

        void AddTomatoes();

        void AddOlives();

        void AddMeat();
    }
}