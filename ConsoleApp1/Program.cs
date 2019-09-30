using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            int side1, side2, side3;
            bool result;
            //Show the menue
            Console.WriteLine("Choose from the menue:\n1. Enter tringle dimenssions\n2. Exit\n");
            //Asking user to choose from the menue if the user enters invalid value the program will ask again until valid entry occurs
            do
            {
                Console.Write("Enter your choice number:");
                input = Console.ReadLine();
            } while (input != "1" && input != "2");
            //when the user enters 2 the program exits
            if (input == "2")
            {
                Environment.Exit(0);
            }
            //Asking user to enter positive integer numbers for triangle sides. the program keep asking until valid entry occurs
            else
            {
                Console.WriteLine("\nEnter triangle sides(integer number greater than 0)");
                do
                {
                    Console.Write("\nEnter side 1: ");
                    result = int.TryParse(Console.ReadLine(), out side1);
                } while (!result || side1 <= 0);
                do
                {
                    Console.Write("\nEnter side 2: ");
                    result = int.TryParse(Console.ReadLine(), out side2);
                } while (!result || side2 <= 0);
                do
                {
                    Console.Write("\nEnter side 3: ");
                    result = int.TryParse(Console.ReadLine(), out side3);
                } while (!result || side3 <= 0);

                //Calling Analyze method to determine if the sides can form a triangle. If yes, what type of tiangle they form
                Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
            }
        }

    }
}
