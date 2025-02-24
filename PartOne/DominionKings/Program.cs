// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter how many estates you possess:");
int estates = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter how many duchies you have:");
int duchies = int.Parse(Console.ReadLine());
Console.WriteLine("And finally provinces:");
int provinces = int.Parse(Console.ReadLine());

int dominion(int a, int b, int c)
{
    return a + (b * 3) + (c * 6);
}

int result = dominion(estates, duchies, provinces);

Console.WriteLine("You have " + result + " points. Well done.");