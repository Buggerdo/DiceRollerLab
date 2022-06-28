using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2
{
    internal class Tools
    {
        public static int Dice()
        {
            int sidesOfDice;

            do
            {
                Console.Clear();
                Console.Write("Please enter home many sides the dice have: ");
            } while(!int.TryParse(Console.ReadLine().Trim(), out sidesOfDice));
            return sidesOfDice;
        }

        public static int Roll(int SidedsOfDice)
        {
            Random rand = new();
            return rand.Next(1, SidedsOfDice + 1);
        }

        public static bool Continue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Would you like to continue playing (Y/N)? ");
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
