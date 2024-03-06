using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "RockPlayer";
        }

        public override void GenerateRoshambo()
        {
            rpsValue = Roshambo.Rock;
        }
    }
}
