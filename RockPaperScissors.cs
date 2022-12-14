Console.WriteLine("Do you want to play a game of Rock Paper Scissors");

var mappings = new Dictionary<char, Values>()
{
    {'r', Values.Rock},
    {'p', Values.Paper},
    {'s', Values.Scissors}
};

var input = Console.ReadKey().KeyChar;

// These are the scores of player and computer that I'm using throughout the program
var playerScore = 0;
var computerScore = 0;
var endGame = false;
while (input == 'y' && endGame == false)
{
    ReportScore(playerScore, computerScore);
    var playerInput = GetPlayerInput(mappings);
    var computerInput = GenerateRandomValue();
    
    // I use this function to take in the player's input (rps) and the computers input(rps) and update the score in here
    var value = PlayAgainstComputer(playerInput, computerInput, ref playerScore, ref computerScore);

    endGame = EndGame();
}
ReportScore(playerScore, computerScore);


static void ReportScore(int playerA, int computerScore)
{
    Console.WriteLine($"\nPlayer A: {playerA} computer: {computerScore}");
}

static Values GetPlayerInput(Dictionary<char, Values> mappings)
{
    var value = ' ';
    while (!mappings.ContainsKey(value))
    {
        Console.WriteLine("\nUse 'r', 'p' or 's' to enter your value");
        value = Console.ReadKey().KeyChar;
    }

    return mappings[value];
}

// I added a return value, completely not necessary. I did it more to see what I liked better. 
int PlayAgainstComputer(Values playerValue, Values computerValue, ref int pScore, ref int cScore)
{
    Console.WriteLine($"\nPlayer A: {playerValue} computer: {computerValue}");
    // If tie, do nothing
    if (playerValue == computerValue)
    {
        return 0;
    }

    // these next 3 blocks should look really familiar
    if (playerValue == Values.Paper)
    {
        if (computerValue == Values.Rock)
        {
            // increment players score by 1
            pScore++;
            return 1;
        }
        else
        {
            // increment computer's score by one
            cScore++;
            return -1;
        }
    }

    if (playerValue == Values.Rock)
    {
        if (computerValue == Values.Scissors)
        {
            pScore++;
            return 1;
        }
        else
        {
            cScore++;
            return -1;
        }
    }

    if (playerValue == Values.Scissors)
    {
        if (computerValue == Values.Rock)
        {
            pScore++;
            return 1;
        }
        else
        {
            cScore++;
            return -1;
        }
    }

    return 0;
}

Values GenerateRandomValue()
{
    var values = Enum.GetValues(typeof(Values));
    var random = new Random();
    return (Values) (values.GetValue(random.Next(values.Length)) ?? throw new InvalidOperationException());
}

static bool EndGame()
{
    Console.WriteLine("\nDo you want to continue?");
    var input = Console.ReadKey().KeyChar;
    if (input == 'y')
    {
        return false;
    }

    return true;
}

internal enum Values
{
    Rock,
    Paper,
    Scissors
}
