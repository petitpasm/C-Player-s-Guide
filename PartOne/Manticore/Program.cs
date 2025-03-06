// See https://aka.ms/new-console-template for more information

int manticoreDistance = -1;
int manticoreHealth = 10;
int damage = 1;
int consolasHealth = 15;
int round = 1;
int cannonRange;

while (manticoreDistance >= 101 || manticoreDistance <= -1)
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
    try
    {
        manticoreDistance = int.Parse(Console.ReadLine());
    }
    catch (IOException e)
    {
        Console.WriteLine(e);
        throw;
    }
    
}

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");

while (manticoreHealth > 0 || consolasHealth > 0)
{
    Status();
    
    cannonRange = int.Parse(Console.ReadLine());

    CheckDamage();
    if (consolasHealth <= 0 || manticoreHealth <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }

    round++;
}

void Status()
{
    Console.WriteLine(new string('-', 30));
        Console.WriteLine("STATUS: Round: " + round.ToString() +
                          "  City: " + consolasHealth.ToString() + "/15  Manticore: " + manticoreHealth.ToString() + "/10");
        Console.WriteLine("The cannon is expected to deal " + SetDamage().ToString() + " damage this round.");
        Console.Write("Enter desired cannon range: ");
}

void CheckDamage()
{
    if (cannonRange > manticoreDistance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        consolasHealth -= damage;
    }
    else if (cannonRange < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        consolasHealth -= damage;
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= damage;
    }
}

int SetDamage()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        return damage = 10;
    } 
    else if (round % 3 == 0 || round % 5 == 0)
    {
        return damage = 3;
    }
    else
    {
        return damage = 1;
    }
}
