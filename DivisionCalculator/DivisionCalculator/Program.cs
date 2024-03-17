using System;

class Program
{
    static void Main()
    {
        int numerator, denominator;

        while (true)
        {
            Console.Write("Please enter the numerator: ");

            if (int.TryParse(Console.ReadLine(), out numerator))
            {
                Console.Write("Please enter the denominator: ");

                if (int.TryParse(Console.ReadLine(), out denominator))
                {
                    try
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero.");
                        }
                        else
                        {
                            Console.WriteLine("The result is {0}.", (float)numerator / denominator);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer for the denominator.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer for the numerator.");
            }

            Console.WriteLine("--- End of Error Handling Example ---");

            Console.Write("Do you want to perform more division? (Y/N): ");
            string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (response == "n")
            {
                break;
            }
            else if (response == "y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                Console.Write("Do you want to perform more division? (Y/N): "); // Repeat the question
            }
        }
    }
}
