
namespace DiceRoller
{
    internal class SixSidedDice
    {
        public static string SixSides(int dieOne, int dieTwo)
        {
            int total = dieOne + dieTwo;
            string combinations;
            string win = string.Empty;


            if(dieOne == 1 && dieTwo == 1) // Snake Eyes: Two 1s
            {
                combinations = "Snake Eyes: Two 1's"; 
            }
            else if(dieOne == 1 && dieTwo == 2 || dieOne == 2 && dieTwo == 1) // Ace Deuce: A 1 and 2
            {
                combinations = "Ace Deuce: A 1 and 2";
            }
            else if(dieOne == 6 && dieTwo == 6) // Box Cars: Two 6s
            {
                combinations = "Box Cars: Two 6s";
            }
            else
            {
                combinations = $"The first die rolled a  {dieOne}\nThe second die rolled a {dieTwo}";
            }

            if(total == 7 || total == 11) //checks for a win
            {
                win = "You win!!";
            }
            else if(total == 2 || total == 3 || total == 12) //Craps: A total of 2, 3, or 12 (Craps is a losing roll)
            {
                win = "Craps, you lost hard";
            }

            return combinations + " \n" + win;

        }
    }
}
