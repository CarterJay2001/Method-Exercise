using System;

namespace MethodExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"This is {name}. {name}\'s favorite color is {favColor}," +
                $" they wish everything was that color. Even {favAnimal}s, which" +
                $" happen to be their favorite animal. If you call {name}\'s name and" +
                $" they don't answer its probably because they're too busy listening" +
                $" to {favBand}. They're always listening to {favBand}.");
        }
    }
}
