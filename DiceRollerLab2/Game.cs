
namespace DiceRoller
{
    internal class Game
    {
        public Game()
        {
            int sidesOfDice = GettingDice.GetDice();
            string output;

            int dieOne = Roll.RollTheDie(sidesOfDice); // gets a new dice roll
            int dieTwo = Roll.RollTheDie(sidesOfDice); // gets a new dice roll
            int total = dieOne + dieTwo;

            Console.WriteLine($"You rolled a {dieOne} and a {dieTwo} for a total of {total}");

            if(sidesOfDice == 6) //Checks for 6 sidded dice
            {
               output = SixSidedDice.SixSides(dieOne, dieTwo, total);
            }
            else
            {
                output = AnyOtherNumberOfSidesOfDice.AnyOtherNumberOfSidesOfDie(dieOne, dieTwo, sidesOfDice, total);
            }
            Console.WriteLine(output.Trim());
        }
    }
}
