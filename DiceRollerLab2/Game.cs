
namespace DiceRoller
{
    internal class Game
    {
        public Game()
        {
            int sidesOfDice = Tools.GetDice();
            string output;

            int dieOne = Tools.RollTheDie(sidesOfDice); // gets a new dice roll
            int dieTwo = Tools.RollTheDie(sidesOfDice); // gets a new dice roll

            if(sidesOfDice == 6) //Checks for 6 sidded dice
            {
               output = SixSidedDice.SixSides(dieOne, dieTwo);
            }
            else
            {
                output = AnyOtherNumberOfSidesOfDice.AnyOtherNumberOfSidesOfDie(dieOne, dieTwo, sidesOfDice);
            }
            Console.WriteLine(output.Trim());
        }
    }
}
