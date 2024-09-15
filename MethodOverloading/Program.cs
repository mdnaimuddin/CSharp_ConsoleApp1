
// this is called as method overloading. It has three methos with same name but taking different number of parameter or different type of parameters.

using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceFriends("Laika", "Albert");
            IntroduceFriends("Naomi", "Jasmine", "Cyrus");
            IntroduceFriends();
        }
        static void IntroduceFriends(string name1, string name2)
        {
            Console.WriteLine($"These are my friends, {name1} and {name2}!");
        }
        static void IntroduceFriends(string name1, string name2, string name3)
        {
            Console.WriteLine($"These are my friends, {name1},{name2} and {name3}!");
        }
        static void IntroduceFriends()
        {
            Console.WriteLine("There is no one who needs to be introduced.");
        }

    }
}
