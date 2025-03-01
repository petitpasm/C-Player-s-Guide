// See https://aka.ms/new-console-template for more information

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What item do you want to see the price of? ");
string response = Console.ReadLine();
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
double price;
price = int.Parse(response) switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

if (name == "Max")
{
    price *= 0.5;
}

Console.WriteLine($"This item cost {price} gold");