using System;

namespace MethodExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("If you are here for MadLibs type 1 and press enter." +
                "\nIf you are here for the calculator type 2 and press enter." +
                "\nIf neither unfortunately you are in the wrong program, type 3 and press enter.");

            int decision1 = Convert.ToInt32(Console.ReadLine());

            switch (decision1)
            {
                case 1:
                    Console.WriteLine("\nGreat we will begin now, all I need you to" +
                        " do is answer a few questions for me please.");

                    string name = Name();

                    string favColor = FavColor();

                    string favAnimal = FavAnimal();

                    string favBand = FavBand();

                    Console.WriteLine($"\nThis is {name}. {name}\'s favorite color is {favColor}," +
                        $" they wish everything was that color. Even {favAnimal}s, which" +
                        $" happen to be their favorite animal.\nIf you call {name}\'s name and" +
                        $" they don't answer its probably because they're too busy listening" +
                        $" to {favBand}. They're always listening to {favBand}.");

                    Console.WriteLine("\nThanks for using MadLibs, hope you enjoyed!");
                    break;

                case 2:
                    Console.WriteLine("\nWelcome to the calculator, which operator " +
                        "would you like to use?:");
                    Console.WriteLine(" 1 for Addition" +
                        "\n 2 for Subtraction" +
                        "\n 3 for Multiplication" +
                        "\n 4 for Division" +
                        "\n 5 for Getting a Remainder");
                    int decision2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nAnd your first number please: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nAnd the second number please:");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    switch (decision2)
                    {
                        case 1:
                            Add();

                            break;

                        case 2:
                            Subtract();

                            break;

                        case 3:
                            Multiply();

                            break;

                        case 4:
                            Divide();

                            break;

                        case 5:
                            Modulus();

                            break;

                        default:
                            Console.WriteLine("Invalid Input, Goodbye!");

                            break;
                    }

                    Console.WriteLine("Thanks for using the calculator! Goodbye!");

                    break;

                case 3:
                    Console.WriteLine("Sorry about that, Goodbye.");

                    break;

                default:
                    Console.WriteLine("Invalid Input Entered, Goodbye.");

                    break;
            }



        }

        public static string Name()
        {
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();

            return name;
        }

        public static string FavColor()
        {
            Console.WriteLine("\nWhat is your favorite color?");
            string favColor = Console.ReadLine();

            return favColor;
        }

        public static string FavAnimal()
        {
            Console.WriteLine("\nWhat is your favorite animal?");
            string favAnimal = Console.ReadLine();

            return favAnimal;
        }

        public static string FavBand()
        {
            Console.WriteLine("\nWhat is your favorite band?");
            string favBand = Console.ReadLine();

            return favBand;
        }

        public static void Add()
        {
            Console.WriteLine("\nAnd your first number please: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd the second number please:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {ans}");
        }
        public static void Subtract()
        {
            Console.WriteLine("\nAnd your first number please: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd the second number please:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {ans}");
        }
        public static void Multiply()
        {
            Console.WriteLine("\nAnd your first number please: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd the second number please:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {ans}");
        }
        public static void Divide()
        {
            Console.WriteLine("\nAnd your first number please: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd the second number please:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {ans}");
        }
        public static void Modulus()
        {
            Console.WriteLine("\nAnd your first number please: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd the second number please:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ans = num1 % num2;
            Console.WriteLine($"The remainder of {num1} and {num2} is {ans}");
        }
    }
}
