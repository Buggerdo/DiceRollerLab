using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Roll
    {
        /// <summary>
        /// Rolls the dice
        /// </summary>
        /// <param name="SidedsOfDice">inputs the number of sides the dice have</param>
        /// <returns>GetDice roll</returns>
        public static int RollTheDie(int SidedsOfDice)
        {
            Random rand = new();
            return rand.Next(1, SidedsOfDice + 1);
        }
    }
}
