using System;
using System.Globalization;
using System.Xml.Linq;
namespace virtualPetSimulator
{
    class pet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pet type \n Fish \n Dog \n Bird \n");
            Console.WriteLine("Enter input");
            string petType = Console.ReadLine();
            Console.WriteLine("Enter pet name");
            Console.WriteLine("Enter input");
            string petName = Console.ReadLine();
            Console.WriteLine("Welcome You have choosen pet type of "+ petType+" "+"and named the"+" "+ petType+" "+"as"+" "+petName);
            int Hunger = 100;
            int Happiness = 100;
            int Health = 100;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter your pet care action \n 1. Feed \n 2. Play \n 3. Rest \n 4. pet status \n 5. Exit");
                Console.WriteLine("Enter input");
                string actionType = Console.ReadLine();
                if (actionType == "1")
                {
                    Hunger = Hunger - 50;
                    Health++;
                    Console.WriteLine(petName + "" + "has been fed Now" + petName + "'s Hunger decreased and Health slightly increased");
                }
                else if (actionType == "2")
                {
                    Happiness = Happiness + 20;
                    Hunger++;
                    Console.WriteLine(petName + " "+"played very well" + petName + "'s Happiness increased and its hunger is slightly increased");
                }
                else if(actionType == "3")
                {
                    Health= Health + 20;
                    Happiness--;
                    Console.WriteLine(petName+" " + "rested very well" + petName + "'s health increased but happiness is slightly decreased");
                }
                else if (actionType == "4")
                {
                    Console.WriteLine($"\nStatus of {petName}:");
                    Console.WriteLine($"Hunger: {Hunger}");
                    Console.WriteLine($"Happiness: {Happiness}");
                    Console.WriteLine($"Health: {Health}");
                }
                else if(actionType== "5")
                {
                    exit = true;
                    break;
                }
            }

        }
    }
}