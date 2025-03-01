// See https://aka.ms/new-console-template for more information

Console.Write("Please enter a x value: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Please enter a y value: ");
int y = int.Parse(Console.ReadLine());

string enemyDirection = "";

if (x < 0)
{
    if (y > 0)
    {
        enemyDirection = "North West";
    }

    if (y == 0)
    {
        enemyDirection = "West";
    }

    if (y < 0)
    {
        enemyDirection = "South West";
    }
}

if (x == 0)
{
    if (y > 0)
    {
        enemyDirection = "North";
    }

    if (y == 0)
    {
        enemyDirection = "here!";
    }

    if (y < 0)
    {
        enemyDirection = "South";
    }
}

if (x > 0)
{
    if (y > 0)
    {
        enemyDirection = "North East";
    }

    if (y == 0)
    {
        enemyDirection = "East";
    }

    if (y < 0)
    {
        enemyDirection = "South East";
    }
}

Console.WriteLine("The enemy is " + enemyDirection);