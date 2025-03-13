string[] menuItems = 
[
    "Add password",
    "Consulter password",
    "Exit"
];

int index = 0;
ConsoleKeyInfo key;

do
{
    Console.Clear();
    foreach (var (idx, menuItem) in menuItems.Index())
    {
        if (idx == index)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine(menuItem);
        Console.ResetColor();
    }
    
    key = Console.ReadKey();

    if (key.Key == ConsoleKey.UpArrow)
    {
        index = Math.Max(0, index - 1);
    } 
    else if (key.Key == ConsoleKey.DownArrow)
    {
        index = Math.Min(menuItems.Length - 1, index + 1);
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        var choice = menuItems[index];
        Console.WriteLine(choice);
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
    
} while (key.Key != ConsoleKey.Escape);

Console.WriteLine("Program ending...");
