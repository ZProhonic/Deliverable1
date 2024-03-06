using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
     class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            Name = "RandomPlayer";
        }

        public override void GenerateRoshambo()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            if (randomNumber == 0)
            {
                 rpsValue = Roshambo.Rock;
            }
            else if (randomNumber == 1)
            {
                rpsValue = Roshambo.Paper;
            }
            else
            {
                 rpsValue = Roshambo.Scissors;
            }

        }
    }
}
