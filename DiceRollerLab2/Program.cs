using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new Game();  // starts a new game
            } while(Tools.ContinueTheGame()); //loops the program 
        }
    }
}
