using System;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string Response = Console.ReadLine();
        if (Response == "No") {
            Console.WriteLine("You are a coward " + name);
        }
        int Score = 0;
        Random random = new Random();
        for (int Round = 1; Round <= 5; Round++)
        {

        if (Response == "Yes") {
            Console.WriteLine("Heads or Tails?");
            int hidden = random.Next(0, 2);
        }
        string Flip = Console.ReadLine();
        if (Flip == "Heads" && random.Next(0, 2) == 1) {
            Console.WriteLine("Correct!");
            Score++;
        } else if (Flip == "Tails" && random.Next(0, 2) == 0) {
            Console.WriteLine("Correct!");
            Score++;
        }
        else {
            Console.WriteLine("Wrong!");
        }

        }   Console.WriteLine("Thank you " + name + ". You got a score of " + Score + "!");
    }
}
    
