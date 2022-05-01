Console.BackgroundColor = ConsoleColor.Black;   // bckgrnd formatting
Console.ForegroundColor = ConsoleColor.Cyan;    // txt formatting

Console.Write("What is the maximum number to reach?\nNo higher than 1,000: ");
var reply = Console.ReadLine();
int.TryParse(reply, out int parsable);

if (parsable > 1000)    // is too big?
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write("\n\nThat's too big! :(");
    Environment.Exit(0);
}

if (parsable == 0)  // is too small or a string (inputting text returns 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n\nThat's not a number/That's too small");
    Environment.Exit(0);
}

Console.Clear();    // clear screen
Console.BackgroundColor = ConsoleColor.DarkMagenta; // bckgrnd formatting
Console.ForegroundColor = ConsoleColor.DarkYellow;  // txt formatting

for (int repeat = 0; repeat < (parsable + 1); repeat++) // see explanation below
{
    Console.WriteLine(repeat);
}
/* int repeat = 0 sets a new value,
 * while repeat is less than the max input: add one then
 * {}: write the int and start again */