using Schachspiel.data;

namespace Schachspiel.firguren;

public class Laeufer : Figur
{
    public Laeufer(Position currentPosition, Player player) : base(currentPosition, player, 'L')
    {
    }

    public override Pair<List<Position>,List<Position>, Int32> getPossibleMoves(SpielFeld spielFeld)
    {
        List<Position> possibleMoves = new();
        List<Position> possibleHits = new();

        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, 1, 1);   // Down-right
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, 1, -1);  // Down-left
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, -1, 1);  // Up-right
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, -1, -1); // Up-left

        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, possibleHits, (possibleMoves.Count()+possibleHits.Count()));
    }
}