// Age verification program that is terminated by user

bool continueProgram = true;

while (continueProgram)
{
    int userAge;

    try
    {
        Console.Write("Please enter your age: ");
        userAge = Convert.ToInt32(Console.ReadLine());

        if (userAge < 0 || userAge > 100)
        {
            Console.WriteLine("Invalid Age");
            Console.WriteLine("Age must be between 0 and 100");
        }
        else if (userAge < 18)
            Console.WriteLine("Sorry you are underage");
        else if (userAge < 21)
            Console.WriteLine("You need parental consent");
        else
        {
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You may sign up for the event!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a numerical value.");
    }

    Console.WriteLine("Press Y to enter another age, or any other key to exit.");
    char key = Console.ReadKey().KeyChar;

    if (key != 'y' && key != 'Y')
    {
        continueProgram = false;
    }
    Console.WriteLine();
}
