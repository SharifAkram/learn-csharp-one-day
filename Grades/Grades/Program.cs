// Program that prompts the user for their grade

while (true)
{
    Console.Write("Enter your grade (type 'exit' to quit): ");
    string? userGrade = Console.ReadLine();

    if (userGrade.ToLower() == "exit")
    {
        break;
    }

    switch (userGrade.ToUpper())
    {
        case "A+":
        case "A":
            Console.WriteLine("Distinction");
            break;
        case "B":
            Console.WriteLine("B Grade");
            break;
        case "C":
            Console.WriteLine("C Grade");
            break;
        default:
            Console.WriteLine("Fail");
            break;
    }
}
