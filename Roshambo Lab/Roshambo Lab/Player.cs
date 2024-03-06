using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
    abstract class Player
    {
        public Roshambo rpsValue { get; set; }

        public string Name { get; set; }


        public abstract void GenerateRoshambo();

    }

}
