using MathGame.Class;

Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date  = DateTime.Now;

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is your math's game\n");
Console.WriteLine($@"What game would you like to play today? choose from the options below:
A - Addition 
S - Subtraction 
M - Multiplication
D - Divison
Q - Quit the program");
Console.WriteLine("----------------------------------------------------------");

var gameSelected = Console.ReadLine()!.Trim().ToUpper();

if (gameSelected == "A")
{
    Game.AdditionGame();
}
else if (gameSelected == "S")
{
    Game.SubstractionGame();
}
else if (gameSelected == "M")
{
    Game.MultiplicationGame();
}
else if (gameSelected == "D")
{
    Game.DivisionGame();
}
else if (gameSelected == "Q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input");
}