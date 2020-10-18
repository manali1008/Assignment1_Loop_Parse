using System;
using System.IO;
using System.Reflection.Metadata;

/// <summary>
/// Find the sum of series of numbers
/// Input - 1 + 4 + 5
/// Output - 10
/// </summary>
namespace Assignment1_Input_Parse_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueToProgram = "N";

            do
            {
                string inputStr;
                Console.WriteLine("------------------Sum of series of numbers------------------\n");
                Console.WriteLine("Input the numbers in a form (eg. 1 + 4 + 5..)\n");

                inputStr = Console.ReadLine();
                string[] numbers = inputStr.Split('+');                

                if (numbers != null && numbers.Length >= 2)
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (int.TryParse(numbers[i], out int number))
                        {
                            sum += number;
                        }
                    }

                    if (sum != 0)
                    {
                        Console.WriteLine($"Output : {sum}");
                    }
                    else
                    {
                        Console.WriteLine("Please provide integer values for summation\n");
                    }                    
                }
                else
                {
                    Console.WriteLine("Please provide valid input in a form (eg. 1 + 4 + 5..)\n");
                }

                Console.WriteLine("Do you want to continue(Press Y - Yes, N - No)");
                continueToProgram = Console.ReadLine().ToUpper();

            } while (continueToProgram == "Y");

        }
    }
}
