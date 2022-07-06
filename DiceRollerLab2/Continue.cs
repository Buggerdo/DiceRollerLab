using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Continue
    {
        /// <summary>
        /// Asks user if they want to play again
        /// </summary>
        /// <returns>True if user wants to continue</returns>
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
