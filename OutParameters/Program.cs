using System;

namespace OutParameters
{
    class Program
    {
        static void CalculateRectangle(int length, int width, out int area, out int perimeter)
        {
            area = length * width;
            perimeter = 2 * (length + width);

        }

        static void Main()
        {
            int length = 18;
            int width = 10;

            CalculateRectangle(length, width, out int area, out int perimeter);

            Console.WriteLine($"Area: {area}"); // Prints "Area: 180"
            Console.WriteLine($"Perimeter: {perimeter}"); // Prints "Perimeter: 56"
            Programs Obj = new();
            Obj.keys();
        }
    }
}



//namespace OutParameters
//{
class Programs
{
    public void keys()
    {
        string scoreAsString = "85.6";
        string statement = "Hello World";

        double scoreAsDouble;
        bool outcome;

        outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

        Console.WriteLine($"{outcome}, {scoreAsDouble}");

        string whispered = Whisper(statement, out bool marker);
        Console.WriteLine(whispered);
    }

    public string Whisper(string phrase, out bool wasWhisperCalled)
    {
        wasWhisperCalled = true;
        return phrase.ToLower();
    }
}
//}
