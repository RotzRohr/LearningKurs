using Schachspiel.data;

namespace Schachspiel.firguren;

public class Bauer : Figur
{
    public Bauer(Position currentPosition, Player player) : base(currentPosition, player, 'B')
    {
    }

    public override Pair<List<Position>,List<Position>,Int32> getPossibleMoves(SpielFeld spielFeld)
    {
        List<Position> possibleMovesTemp = new();

        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y));
        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y));

        if (player == Player.WHITE)
        {
            if(currentPosition.X == 6)
            {
                possibleMovesTemp.Add(new Position(currentPosition.X - 2, currentPosition.Y));
            }
        }
        else
        {
            if(currentPosition.X == 1)
            {
                possibleMovesTemp.Add(new Position(currentPosition.X + 2, currentPosition.Y));
            }
        }

        List<Position> possibleMoves = new();

        foreach (Position move in possibleMovesTemp)
        {
            if (spielFeld.StillInField(move) && spielFeld.GetFigur(move)==null)
            {
                //check for balck or white
                if (player == Player.WHITE)
                {
                    if(move.X < currentPosition.X)
                    {
                        possibleMoves.Add(move);
                    }
                }
                else
                {
                    if(move.X > currentPosition.X)
                    {
                        possibleMoves.Add(move);
                    }
                }
            }
        }

        List<Position> possibleSchlagTemp = new();

        possibleSchlagTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y + 1));
        possibleSchlagTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y + 1));
        possibleSchlagTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y - 1));
        possibleSchlagTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y - 1));

        List<Position> possibleSchlag = new();
        foreach (Position move in possibleSchlagTemp)
        {
            if (spielFeld.StillInField(move) && spielFeld.GetFigur(move)!=null && spielFeld.GetFigur(move).player != player)
            {
                //check for balck or white
                if (player == Player.WHITE)
                {
                    if(move.X < currentPosition.X)
                    {
                        possibleSchlag.Add(move);
                    }
                }
                else
                {
                    if(move.X > currentPosition.X)
                    {
                        possibleSchlag.Add(move);
                    }
                }
            }
        }



        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, possibleSchlag, (possibleMoves.Count()+possibleSchlag.Count()));
    }
}