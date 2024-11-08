Console.WriteLine("Hello, World!\n");
Console.WriteLine("The current time is " + DateTime.Now);

DateTime today = DateTime.Today;
DateTime nextChristmas = new DateTime(today.Year, 12, 25);
int daysUntilChristmas = (nextChristmas - today).Days;

Console.WriteLine($"\nThere are {daysUntilChristmas} days until the next Christmas.\n");

// Define the height of the tree
int treeHeight = 10;

// Draw the tree
for (int i = 0; i < treeHeight; i++)
{
    // Print spaces for alignment
    Console.Write(new string(' ', treeHeight - i));

    // Print the asterisks for the tree
    Console.WriteLine(new string('*', 2 * i + 1));
}

// Draw the trunk of the tree
int trunkWidth = 3;
int trunkHeight = 2;
int trunkSpace = treeHeight - 1;

for (int i = 0; i < trunkHeight; i++)
{
    Console.Write(new string(' ', trunkSpace));
    Console.WriteLine(new string('|', trunkWidth));
}