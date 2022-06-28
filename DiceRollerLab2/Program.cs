using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new Game(); 
            } while(Tools.Continue());
        }
    }
}
