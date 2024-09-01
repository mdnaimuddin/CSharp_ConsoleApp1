/*loops through a list of numbers and prints whether each is even or odd*/

using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace EvenOddchecker
{
    class Progran
    {
       static void Main(string[] args)
       // static void p1 (string[] args)
        {
            // define list of nr
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Loop through each number in the list

            foreach (int number in numbers)
            {
                // check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is even odd.");
                }
            }
        }
    }
}