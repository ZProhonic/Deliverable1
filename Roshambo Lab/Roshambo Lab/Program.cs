using Roshambo_Lab;

string userSelection = "";

Console.WriteLine("Welcome to Rock, Paper , Scissors!");
Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();

HumanPlayer human = new HumanPlayer(userName);


bool loopAgain = true;
string playerSelection = "";
Player opponent = null;


while (loopAgain == true)
{
    Console.WriteLine("Would you like to play against Scott or Cass? (S/C)");
    playerSelection = Console.ReadLine();

    switch (playerSelection.ToLower().Trim())
    {
        case "scott":
        case "s":
            Console.WriteLine("Scott will be your opponent");
            opponent = new RockPlayer();
            loopAgain = false;
            break;
        case "cass":
        case "c":
            Console.WriteLine("Cass will be your opponent");
            opponent = new RandomPlayer();
            loopAgain = false;
            break;
            default:
            Console.WriteLine("Please enter a valid opponent");
            break;
    }
}



bool playAgain = true;

do
{
    while (true)
    {
        human.GenerateRoshambo();
        opponent.GenerateRoshambo(); //If "opponent" variable is not set to Null above, an error is recieved saying here saying "opponent" is unassigned. Google said to set it to Null to fix.

        Console.WriteLine($"{human.Name}: {human.rpsValue}");
        Console.WriteLine($"{opponent.Name}: {opponent.rpsValue}");

        if (human.rpsValue == opponent.rpsValue)
        {
            Console.WriteLine("Draw!");
        }
        else if ((human.rpsValue == Roshambo.Rock && opponent.rpsValue == Roshambo.Scissors) 
            || (human.rpsValue == Roshambo.Paper && opponent.rpsValue == Roshambo.Rock) 
            || (human.rpsValue == Roshambo.Scissors && opponent.rpsValue == Roshambo.Paper))
        {
            Console.WriteLine($"{human.Name} wins!");
        }
        else
        {
            Console.WriteLine($"{opponent.Name} wins!");
        }

        Console.WriteLine("Play again? Y/N");
        string continuePlaying = Console.ReadLine().ToLower().Trim();
        if (continuePlaying == "y")
        {
            break;
        }
        else if (continuePlaying == "n")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = false;
            break;
        } 
        else
        {
            Console.WriteLine("That is not a valid option. Please indicate if you would like to play again");
        }
    }

} while (playAgain == true);



