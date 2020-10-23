using Lab1.Classes;
using Lab2.AbstractClasses;
using System;

namespace Lab2
{

    class Program
    {
        public static void MakeCustomPizza(PizzaMaker builder)
        {
            bool loopBreak = true;
            string str = null;
            while (str != "0")
            {
                
                Console.WriteLine("\nChoose your option:\n");
                Console.WriteLine("1 - Add Cheese\n2 - Add Tomatoes\n" +
                    "3 - Add Olives\n4 - Add Meat\n" +
                    "5 - Make Pizza\n\n0 - exit\n");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1": builder.AddCheese(); loopBreak = false; break;
                    case "2": builder.AddTomatoes(); loopBreak = false; break;
                    case "3": builder.AddOlives(); loopBreak = false; break;
                    case "4": builder.AddMeat(); loopBreak = false; break;
                    case "5": Console.Write(builder.GetPizza().ListIngredients()); loopBreak = true; break; 
                    case "0": loopBreak = true; break;
                    default: Console.WriteLine("Enter the required number"); break;
                }
                if(loopBreak != false)
                {
                    builder.Reset();
                    break;
                }
                
            }
        }
        static void Main(string[] args)
        {      
            var director = new Cafe();
            var builder = new PizzaMaker();
            director.Builder = builder;                    
            string str = null;

            while(str != "0")
            {
                
                Console.WriteLine("Choose your option:\n");
                Console.WriteLine("1 - Margarita\n2 - Carbonara\n" +
                    "3 - Italian\n4 - Pepperoni\n" +
                    "5 - Custom pizza\n\n0 - exit\n");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            director.makeMargarita();
                            Console.WriteLine(builder.GetPizza().ListIngredients());
                            break;
                        }
                    case "2": 
                        { 
                            director.makeCarbonara(); 
                            Console.WriteLine(builder.GetPizza().ListIngredients()); 
                            break; 
                        }
                    case "3": 
                        { 
                            director.makeItalian(); 
                            Console.WriteLine(builder.GetPizza().ListIngredients()); 
                            break; 
                        }
                    case "4": 
                        { 
                            director.makePepperoni();
                            Console.WriteLine(builder.GetPizza().ListIngredients());
                            break; 
                        }
                    case "5":
                        { 
                            MakeCustomPizza(builder);
                            break; 
                        }
                    case "0":
                        { 
                            Environment.Exit(0);
                            break; 
                        }
                    default: Console.WriteLine("Enter the required number"); break;
                }
            }     
        }
    }
}