using Schachspiel.data;

namespace Schachspiel.firguren;

public class Dame : Figur
{
    public Dame(Position currentPosition, Player player) : base(currentPosition, player, 'D')
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
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, 0, 1);  // Right
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, 0, -1); // Left
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, 1, 0);  // Down
        AddMovesInDirection(spielFeld, possibleMoves, possibleHits, -1, 0); // Up

        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, possibleHits, (possibleMoves.Count()+possibleHits.Count()));
    }
}