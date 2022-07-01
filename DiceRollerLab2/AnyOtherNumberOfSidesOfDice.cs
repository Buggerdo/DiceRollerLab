using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class AnyOtherNumberOfSidesOfDice
    {
        public static string AnyOtherNumberOfSidesOfDie(int dieOne, int dieTwo, int sidesOfDice)
        {
            int total = dieOne + dieTwo;
            string combinations = string.Empty;
            string win;

            if(dieOne == 4 && dieTwo == 4)
            {
                combinations = "Double 4's? What good is that?";
            }
            else if(sidesOfDice%2 == 0 && dieOne + dieTwo == sidesOfDice)
            {
                combinations = "You got 50%";
            }
            else if(dieOne == 40 && dieTwo == 4)
            {
                combinations = "File not found";
            }
            else if(dieOne == sidesOfDice && dieTwo == sidesOfDice)
            {
                combinations = "Critical hit!";
            }
            else
            {
                combinations = $"The first die rolled a  {dieOne}\nThe second die rolled a {dieTwo}";
            }

            if(total == 2 || total > sidesOfDice/2)
            {
                win = "\nYou win this round";
            }
            else
            {
                win = "\nYou loose this round";
            }
           
            return combinations + " " + win;
        }
    }
}
