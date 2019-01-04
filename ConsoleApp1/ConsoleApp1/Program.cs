using System;

namespace ConsoleApp1
{
    class Dog
    {
        public string Type;
        public int Year;
        public string Color;

        public Dog(string type, int year, string color)
        {
            Type = type;
            Year = year;
            Color = color;
        }
    }
    class Program
    {
        public static void Main()
        {
            Dog bailey = new Dog("border collie", 5, "black and white");
            Dog cooper = new Dog("boxer", 1, "brown");
            Dog lila = new Dog("pom", 3, "light brown");
            Console.WriteLine(bailey.Type);
            Console.WriteLine(cooper.Year);
            Console.WriteLine(lila.Color);
        }
    }
}