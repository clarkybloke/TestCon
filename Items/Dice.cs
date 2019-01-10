using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public static class Dice
    {
        static readonly Random RandomDice = new Random( DateTime.Now.Millisecond);

        public static int Throw(int dice, int numberofdice)
        {
            var total = 0;

            for (var i = 0; i < numberofdice; i++)
                total += RandomDice.Next(1, dice);

            return total;
        }

    }
}
