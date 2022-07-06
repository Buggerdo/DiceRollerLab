
namespace DiceRoller
{
    internal class GettingDice
    {
        /// <summary>
        /// Askes user for the number of sides on the dice
        /// </summary>
        /// <returns>The number of sides that the dice have</returns>
        public static int GetDice()
        {
            int sidesOfDice;

            do
            {
                Console.Clear();
                Console.Write("Please enter home many sides the dice have: ");
            } while(!int.TryParse(Console.ReadLine().Trim(), out sidesOfDice) || sidesOfDice < 1);
            return sidesOfDice;
        }
    }
}
