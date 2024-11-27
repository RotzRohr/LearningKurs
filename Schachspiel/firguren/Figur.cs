using Schachspiel.data;

namespace Schachspiel.firguren;

public abstract class Figur
{
    public Position currentPosition;
    public Player player;
    private char symbol;

    public Figur(Position currentPosition, Player player, char symbol)
    {
        this.currentPosition = currentPosition;
        this.player = player;
        this.symbol = symbol;
    }

    public abstract Pair<List<Position>,List<Position>,Int32> getPossibleMoves(SpielFeld spielFeld);

    public string getSpielFeldSymbol()
    {
        return symbol + (player == Player.WHITE ? "1" : "2");
    }


    protected void AddMovesInDirection(SpielFeld spielFeld, List<Position> possibleMoves, int xIncrement, int yIncrement) //1 0
    {
        int x = currentPosition.X + xIncrement;
        int y = currentPosition.Y + yIncrement;

        while (spielFeld.StillInField(new Position(x, y)))
        {
            Position newPos = new Position(x, y);
            Figur? figurAtNewPos = spielFeld.GetFigur(newPos);

            if (figurAtNewPos == null)
            {
                possibleMoves.Add(newPos);
                x += xIncrement;
                y += yIncrement;
            }
            else
            {
                break;
            }
        }
    }

}