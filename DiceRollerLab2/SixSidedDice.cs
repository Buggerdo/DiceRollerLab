using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2
{
    internal class SixSidedDice
    {
        public SixSidedDice(int DieOne, int DieTwo)
        {
            if(DieOne == 1 && DieTwo == 1) Console.WriteLine("Snake Eyes: Two 1s");

            else if(DieOne == 1 && DieTwo == 2 || DieOne == 2 && DieTwo == 1) Console.WriteLine("Ace Deuce: A 1 and 2");

            Console.WriteLine(DieOne);
            Console.WriteLine(DieTwo);
        }
    }
}
