using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Tools
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


        /// <summary>
        /// Asks user if they want to play again
        /// </summary>
        /// <returns></returns>
        public static bool ContinueTheGame()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Would you like to play again (Y/N)? ");
                string awnser = Console.ReadLine().ToLower().Trim();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
                Console.Clear();
            } while(true);

        }
    }
}
