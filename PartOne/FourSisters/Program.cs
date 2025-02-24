// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter how many eggs you gathered:");
int eggs = int.Parse(Console.ReadLine());
const int sisters = 4;

int eggsPerSisters = eggs / sisters;
int eggsForDuckbear = eggs % sisters;

Console.WriteLine("It means each sister will have " + eggsPerSisters + " eggs, and Duckbear will have " + eggsForDuckbear + " eggs.");