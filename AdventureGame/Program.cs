/*Here's a simple "Choose Your Own Adventure" game in C# 
 * that uses a while loop to ensure the user chooses a correct option:*/


using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Choose Your Own Adventure game!");
            Console.WriteLine("You find yourself at the entrance of a dark cave.");
            Console.WriteLine("Do you want to enter the cave or walk away?");
            Console.WriteLine("Type 'enter' to enter the cave or 'walk' to walk away.");

            string choice = "";
            while (choice != "enter" && choice != "walk")
            {
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToLower();

                if (choice == "enter")
                {
                    Console.WriteLine("You bravely enter the cave. It's dark and damp inside.");
                    Console.WriteLine("You see a flickering light ahead. Do you want to approach the light or turn back?");
                    Console.WriteLine("Type 'approach' to approach the light or 'back' to turn back.");

                    string caveChoice = "";
                    while (caveChoice != "approach" && caveChoice != "back")
                    {
                        Console.Write("Enter your choice: ");
                        caveChoice = Console.ReadLine().ToLower();

                        if (caveChoice == "approach")
                        {
                            Console.WriteLine("You walk towards the light and find a treasure chest! You've found gold!");
                        }
                        else if (caveChoice == "back")
                        {
                            Console.WriteLine("You decide to turn back and leave the cave safely.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please type 'approach' or 'back'.");
                        }
                    }
                }
                else if (choice == "walk")
                {
                    Console.WriteLine("You walk away from the cave, deciding it's not worth the risk.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please type 'enter' or 'walk'.");
                }
            }

            Console.WriteLine("Thank you for playing the Choose Your Own Adventure game!");
        }
    }
}

