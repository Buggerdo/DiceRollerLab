
namespace DiceRoller
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new Game();  // starts a new game
            } while(Continue.ContinueTheGame()); //loops the program 
        }
    }
}
