using Schachspiel.data;
using Schachspiel.firguren;

namespace Schachspiel;

class Program
{
    static void Main(string[] args)
    {
        SpielFeld spielFeld = new SpielFeld();
        Player player = Player.WHITE;
        while (true)
        {
            spielFeld.PrintSpielFeld();
            spielFeld.TakeTurn(player);
            //player = player == Player.WHITE ? Player.BLACK : Player.WHITE;
        }
    }
}