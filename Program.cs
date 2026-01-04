
// Initializers
Random random = new Random();

// The actual game
Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}
else
{
    // exit Application.
}

//Methods

bool ShouldPlay()
{
    while (true)
    {
        string input = Console.ReadLine()?.ToUpper() ?? "";

        if (input == "Y")
        {
            return true;
        }
        if (input == "N")
        {
            return false;
        }

        Console.WriteLine("Invalid input, please enter Y/N to continue:");
    }
}

//WinOrLose Method where if the if target < roll then win and if target > roll then Lose
void WinOrLose(int target, int roll)
{
    if (target < roll)
    {
        Console.WriteLine("You Win!");
    }
    else
    {
        Console.WriteLine("You lose!");
    }
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win! Press Enter to roll");
        Console.ReadKey();
        Console.WriteLine($"You rolled a {roll}");
        WinOrLose(target, roll);
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}