// Ask the computer do you want to play a game?

using System.Globalization;

Console.WriteLine("Do you want to play a game of Rock Paper Scissors");

char input = Console.ReadKey().KeyChar;;
int playerScore = 0;
int computerScore = 0;

while (Char.ToLower(input, CultureInfo.InvariantCulture) == 'y' )
{
    input = Console.ReadKey().KeyChar;
}

HashSet<char> validKeys = new HashSet<char>()
{
    'r', 'p', 's'
};






// This exists in python but you do not have to do it this way
enum Values{
    Rock, Paper, Scissors
}





