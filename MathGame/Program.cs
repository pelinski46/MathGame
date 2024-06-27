using MathGame.Class;

string name = GetName();
var date = DateTime.Now;

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
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
    switch (gameSelected)
    {
        case "A":
            Game.AdditionGame();
            break;
        case "S":
            Game.SubstractionGame();
            break;
        case "M":
            Game.MultiplicationGame();
            break;
        case "D":
            Game.DivisionGame();
            break;
        case "Q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("invalid input");
            Environment.Exit(1);
            break;

    }
    Console.ReadKey();
}

