using Mission3;

Boolean programLooper = true;
List<FoodItem> foodItems = new List<FoodItem>();

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
            Console.WriteLine("Enter Food Item Name: ");
            string itemName = Console.ReadLine();   
            
            Console.WriteLine("Enter Category: ");
            string itemCategory = Console.ReadLine();
            
            Console.WriteLine("Enter Quantity: ");
            string Quantityinput = Console.ReadLine();
            
            Console.WriteLine("Enter Expiration Date: ");
            string  ExpDateInput = Console.ReadLine();
            if (
                int.TryParse(Quantityinput, out int itemQuantity) &&
                DateTime.TryParse(ExpDateInput, out DateTime itemExpirationDate)
            )
            {
                var fooditem = new FoodItem(itemName, itemCategory, itemQuantity, itemExpirationDate);
                foodItems.Add(fooditem);
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }

            break;
        case 2:
            int i = 0;
            while ( i < foodItems.Count)
            {
                Console.WriteLine(i +1);    
                Console.WriteLine(foodItems[i].Name);
                i++;
            }
            break;
        case 3:
            foreach (var item in foodItems)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Quantity);
                Console.WriteLine(item.ExpirationDate);
                Console.WriteLine(" ------ " );
            }
            Console.WriteLine("Press any key to return to Main Menu ...");
            Console.ReadKey();  
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