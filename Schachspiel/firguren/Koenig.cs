using Schachspiel.data;

namespace Schachspiel.firguren;

public class Koenig : Figur
{
    public Koenig(Position currentPosition, Player player) : base(currentPosition, player, 'K')
    {
    }

    public override Pair<List<Position>,List<Position>, Int32> getPossibleMoves(SpielFeld spielFeld)
    {
        List<Position> possibleMovesTemp = new();

        possibleMovesTemp.Add(new Position(currentPosition.X, currentPosition.Y + 1));
        possibleMovesTemp.Add(new Position(currentPosition.X, currentPosition.Y - 1));
        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y));
        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y));

        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y + 1));
        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y + 1));
        possibleMovesTemp.Add(new Position(currentPosition.X - 1, currentPosition.Y - 1));
        possibleMovesTemp.Add(new Position(currentPosition.X + 1, currentPosition.Y - 1));


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
                else if(figur==null)
                {
                    possibleMoves.Add(move);
                }
            }
        }

        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, possibleHits, (possibleMoves.Count()+possibleHits.Count()));
    }
}