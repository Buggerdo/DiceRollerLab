using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2
{
    internal class Game
    {
        public Game()
        {
            int sidesOfDice = Tools.Dice();

            int DieOne = Tools.Roll(sidesOfDice);
            int DieTwo = Tools.Roll(sidesOfDice);

            if(sidesOfDice == 6)
            {
                _ = new SixSidedDice(DieOne, DieTwo);
            }
        }
    }
}
