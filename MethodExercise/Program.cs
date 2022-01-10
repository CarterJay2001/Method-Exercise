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
                    Console.WriteLine("Great we will begin now, all I need you to" +
                        " do is answer a few questions for me please.");

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

                    Console.WriteLine("\nThanks for using MadLibs, hope you enjoyed!");
                    break;

                case 2:
                    Console.WriteLine("Welcome to the calculator, what operator " +
                        "would you like to use?");
                    Console.WriteLine(" 1 for Addition" +
                        "\n 2 for Subtraction" +
                        "\n 3 for Multiplication" +
                        "\n 4 for Division" +
                        "\n 5 for Getting a Remainder");
                    int decision2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("And your first number please: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("And the second number please:");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    switch (decision2)
                    {
                        case 1:
                            Add(n1, n2);

                            break;

                        case 2:
                            Subtract(n1, n2);

                            break;

                        case 3:
                            Multiply(n1, n2);

                            break;

                        case 4:
                            Divide(n1, n2);

                            break;

                        case 5:
                            Modulus(n1, n2);

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

        public static int Add(int num1, int num2)
        {
            int ans = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {ans}");
            return ans;
        }
        public static int Subtract(int num1, int num2)
        {
            int ans = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {ans}");
            return ans;
        }
        public static int Multiply(int num1, int num2)
        {
            int ans = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {ans}");
            return ans;
        }
        public static int Divide(int num1, int num2)
        {
            int ans = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {ans}");
            return ans;
        }
        public static int Modulus(int num1, int num2)
        {
            int ans = num1 % num2;
            Console.WriteLine($"The remainder of {num1} and {num2} is {ans}");
            return ans;
        }
    }
}
