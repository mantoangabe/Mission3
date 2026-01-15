Boolean programLooper = true;
while (programLooper == true)
{
    Console.WriteLine("Welcome to Food Bank Inventory Program!");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add Food Items");
    Console.WriteLine("2. Delete Food Items");
    Console.WriteLine("3. View Food Items");
    Console.WriteLine("4. Exit");
    Console.Write("Please enter your choice: (1-4)");
    if (!Int32.TryParse(Console.ReadLine(), out int userInput))
    {
        Console.WriteLine("Invalid input, please try again");
        continue;
    }

    switch (userInput)
    {
        case 1:
            //Add class
            break;
        case 2:
            //delete class
            break;
        case 3:
            //View food items
            break;
        case 4:
            programLooper = false;
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Please choose a valid option. \n");
            break;
            
    }
    
}