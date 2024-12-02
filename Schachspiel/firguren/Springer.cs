using Schachspiel.data;

namespace Schachspiel.firguren;

public class Springer : Figur
{
    public Springer(Position currentPosition, Player player) : base(currentPosition, player, 'S')
    {
    }

    public override Pair<List<Position>,List<Position>, Int32> getPossibleMoves(SpielFeld spielFeld)
    {
        List<Position> possibleMovesTemp = new();

        possibleMovesTemp.Add(new Position(currentPosition.X + 2, currentPosition.Y + 1));
        possibleMovesTemp.Add(new Position(currentPosition.X + 2, currentPosition.Y - 1));

        possibleMovesTemp.Add(new Position(currentPosition.X - 2, currentPosition.Y + 1));
        possibleMovesTemp.Add(new Position(currentPosition.X - 2, currentPosition.Y - 1));

        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y + 2));
        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y + 2));

        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y - 2));
        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y - 2));

        List<Position> possibleMoves = new();
        List<Position> possibleHits = new();

        foreach (Position move in possibleMovesTemp)
        {
            if (spielFeld.StillInField(move))
            {
                Figur? figur = spielFeld.GetFigur(move);
                if(figur!=null && figur.player!=player)
                {
                    possibleHits.Add(move);
                }
                else
                {
                    possibleMoves.Add(move);
                }
            }
        }

        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, possibleHits, (possibleMoves.Count()+possibleHits.Count()));
    }
}