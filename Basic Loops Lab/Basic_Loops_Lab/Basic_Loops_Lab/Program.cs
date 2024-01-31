bool loopAgain = false;
do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    loopAgain = Console.ReadLine().ToLower().Trim() == "y" ? true : false;
} while (loopAgain == true);

Console.WriteLine("Goodbye!");

bool playAgain = false;
do
{
    Console.WriteLine("Please enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    int secondLoop = 0;
    do
    {
        Console.WriteLine(secondLoop);
        secondLoop++;
        
    } while (secondLoop <= userNumber);
    
    Console.WriteLine("Would you like to continue? (y/n)");
    playAgain = Console.ReadLine().ToLower().Trim() == "y" ? true : false;
} while (playAgain == true);

bool lockedDoor = true;
int numberOfAttempts = 5;
while (lockedDoor)
{
        Console.WriteLine("Please enter passcode: ");
        int userInput = int.Parse(Console.ReadLine().Trim());
        if (userInput == 13579)
        {
            Console.WriteLine("Welcome");
            lockedDoor = false;
        } 
        else if (numberOfAttempts == 1)
        {
        Console.WriteLine("Too many incorrect attempts. System locked.");
        lockedDoor = false;
        }
        numberOfAttempts--;

} 










