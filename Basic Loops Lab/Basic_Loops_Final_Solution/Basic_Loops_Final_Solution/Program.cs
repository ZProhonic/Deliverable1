int numberOfAttempts = 5;
bool lockedDoor = true;
do
{
    Console.WriteLine("Please enter passcode:");
    int userInput = int.Parse(Console.ReadLine());
    if (userInput == 13579)
    {
        Console.WriteLine("Welcome!");
        lockedDoor = false;
    }
    else if (numberOfAttempts == 1)
    {
        Console.WriteLine("Too many incorrect attempts. Locked out.");
        lockedDoor = false;  
    }
    numberOfAttempts--;

} while (lockedDoor == true);

