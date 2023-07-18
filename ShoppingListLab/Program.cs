Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    {"chips", 3.99m },
    {"soda", 5.50m },
    {"hotdog", 2.50m },
    {"candy", 3.25m },
    {"slushie", 5.00m },
    {"pizza", 4.75m },
    {"pretzel", 4.50m },
    { "water", 2.00m }
};

List<string> shoppingList = new List<string>();

Console.WriteLine("Welcome to Maya's Market!");

while (true)
{
    Console.WriteLine("Menu:");
    foreach (var item in menu)
    {
        Console.WriteLine($"{item.Key}: ${item.Value}");
    }

    Console.WriteLine("What would you like to order? or type 'done' to exit: ");
    string itemName = Console.ReadLine();

    if (itemName.ToLower() == "done")
    {
        break;
    }

    if (menu.ContainsKey(itemName))
    {
        Console.WriteLine($"{itemName}: ${menu[itemName].ToString("0.00")}");
        shoppingList.Add(itemName);
    }
    else
    {
        Console.WriteLine("Oopsie, looks like we don't sell that item in the menu.");
    }
}

Console.WriteLine("\nOrder Summary:");
Console.WriteLine("Item name    |   Price");
Console.WriteLine("-----------------------");
decimal total = 0;

foreach (var item in shoppingList)
{
    decimal price = menu[item];
    Console.WriteLine($"{item, -12} | ${price.ToString("0.00")}");
    total += price;
}

Console.WriteLine("------------------------");
Console.WriteLine($"Total        |  ${total.ToString("0.00")}");