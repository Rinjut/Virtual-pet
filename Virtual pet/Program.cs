using System;
namespace virtualPetSimulator
{
    class Pets
    {
        static void main(String[] args)
        {
            Console.WriteLine("Enter your pet type \n.1 Fish \n 2. Dog \n 3. parrot \n");
            string petType = Console.ReadLine();
            Console.WriteLine("Enter pet name");
            string petName = Console.ReadLine();
            Console.WriteLine("Welcome" + petName);
        }
    }
}