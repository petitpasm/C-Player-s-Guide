// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); /*Stores the kind of item*/
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); //Stores the description of said item.
string c = " of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + c + " " + d + "!");

//To make this code more readable, I suggest to get rid of "c" and "d" variables
//and rename "a" and "b" to be more understandable. Like so:

Console.WriteLine("What kind of thing are we talking about?");
string kind = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string description = Console.ReadLine();
Console.WriteLine("The " + description + " " + kind + " of Doom 3000!");

//We get it faster and we can read this later without lost infos.