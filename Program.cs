Console.WriteLine("Do you want to play a game of Rock Paper Scissors");

char input = Console.ReadKey().KeyChar;;
Console.WriteLine(input);
int playerScore = 0;
int computerScore = 0;
bool endGame = false;
if (input == 'y' && !endGame)
{
    ReportScore(playerScore, computerScore);
    
}

Dictionary<char, Values> mappings = new Dictionary<char, Values>()
{
    {'r', Values.Rock},
    {'p', Values.Paper},
    {'s', Values.Scissors},
};

static void ReportScore(int playerA, int computerScore)
{
    Console.WriteLine($"player A: {playerA} computer: {computerScore}");
}
static Values GetPlayerInput()
{
    Console.WriteLine();
    return Values.Paper;
}

enum Values{
    Rock, Paper, Scissors
}