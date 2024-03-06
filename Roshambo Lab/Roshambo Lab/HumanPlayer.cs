using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override void  GenerateRoshambo()
        {
            string playerChoice = "";

            while (true)
            {
                Console.WriteLine("Rock, Paper, or Scissors? R/P/S");
                playerChoice = Console.ReadLine().ToLower().ToLower();
                if (playerChoice == "r")
                {
                    rpsValue = Roshambo.Rock;
                    break;
                }
                else if (playerChoice == "p")
                {
                    rpsValue = Roshambo.Paper;
                    break;
                }
                else if (playerChoice == "s")
                {
                    rpsValue = Roshambo.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }


        }
    }
}
