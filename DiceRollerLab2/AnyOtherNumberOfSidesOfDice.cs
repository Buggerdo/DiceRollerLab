
namespace DiceRoller
{
    internal class AnyOtherNumberOfSidesOfDice
    {
        public static string AnyOtherNumberOfSidesOfDie(int dieOne, int dieTwo, int sidesOfDice, int total)
        {
            string combinations = string.Empty;
            string win = string.Empty;

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
