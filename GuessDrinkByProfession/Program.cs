using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessDrinksByProfession
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("I bet I can guess your drink of choice.  Just tell me what you do for a living");
                string favDrink = Console.ReadLine();

                switch (favDrink)
                {
                    case "Jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "Assistant Principal":
                        Console.WriteLine("Anything with ALCOHOL!!!");
                        break;
                    case "Programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "Bike Gang Member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "Politician":
                        Console.WriteLine("Your tax dollars Sucka!");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
        }
    }
}