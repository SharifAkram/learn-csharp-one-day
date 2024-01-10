using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Logarithm");
            Console.WriteLine("6. Sine");
            Console.WriteLine("7. Cosine");
            Console.WriteLine("8. Tangent");
            Console.WriteLine("9. Exit");

            Console.Write("Enter your choice (1-9): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 9)
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    break;
                case 2:
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    break;
                case 3:
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    break;
                case 4:
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue; // Restart the loop
                    }
                    break;
                case 5:
                    Console.Write("Enter the base for the logarithm: ");
                    double logBase = Convert.ToDouble(Console.ReadLine());
                    result = Math.Log(num1, logBase);
                    break;
                case 6:
                    result = Math.Sin(num1);
                    break;
                case 7:
                    result = Math.Cos(num1);
                    break;
                case 8:
                    result = Math.Tan(num1);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                    continue; // Restart the loop
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
