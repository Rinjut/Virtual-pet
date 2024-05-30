using System;

namespace virtualPetSimulator
{
    class pet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual pet world!");
            Console.WriteLine("Enter your pet type \n 1. Cat \n 2. Dog \n 3. Rabbit \n");
            string petType = Console.ReadLine();
            Console.WriteLine("Enter pet name");
            string petName = Console.ReadLine();
            Console.WriteLine("WELCOME! You have choosen pet type of "+ petType+" "+"and named the"+" "+ petType+" "+"as"+" "+petName);
            //Initialization of pet status
            int Hunger = 5;
            int Happiness = 5;
            int Health = 5;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter your pet care action \n 1. Feed \n 2. Play \n 3. Rest \n 4. pet status \n 5. Exit");
                string actionType = Console.ReadLine();
                // condition for Feed the pet
                if (actionType == "1")
                {
                    Hunger -= 2;
                    Health += 1;
                    Console.WriteLine(petName + " " + "has been fed. Now"+" " + petName + "'s Hunger decreased and Health slightly increased");
                }
                //condition for play with the pet
                else if (actionType == "2")
                {
                    Happiness += 2;
                    Hunger += 2;
                    Console.WriteLine(petName + " "+"played very well."+" " + petName + "'s Happiness increased and its hunger is slightly increased");
                }
                //condition to let the pet rest 
                else if(actionType == "3")
                {
                    Health += 2;
                    Happiness -= 1;
                    Console.WriteLine(petName+" " + "rested very well."+" " + petName + "'s health increased but happiness is slightly decreased");
                }
                //condition for checking pet status
                else if (actionType == "4")
                {
                    Console.WriteLine("\nStatus of" + " " +petName);
                    Console.WriteLine("Hunger:" + " " + Hunger);
                    Console.WriteLine("Happiness:" + " " + Happiness);
                    Console.WriteLine("Health:"+" "+Health);
                }
                //condition for exit from virtual pet simulator
                else if(actionType== "5")
                {
                    Console.WriteLine("Exited from virtual pet world");
                    exit = true;
                    break;
                }
              
                //Critical warning
                if(Hunger >=10)
                {
                    Console.WriteLine("Warning! Your pet is very hungry");
                    Health -= 2;
                }
                //health deterioration  warning
                if (Health <= 2)
                {
                    Console.WriteLine("WARNING! Your pet's health has deteriorated and refusing to play.Please feed the pet as soon as possible.");
                }
            }
           

        }
    }
}