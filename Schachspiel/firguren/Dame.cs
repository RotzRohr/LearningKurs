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

        AddMovesInDirection(spielFeld, possibleMoves, 1, 1);   // Down-right
        AddMovesInDirection(spielFeld, possibleMoves, 1, -1);  // Down-left
        AddMovesInDirection(spielFeld, possibleMoves, -1, 1);  // Up-right
        AddMovesInDirection(spielFeld, possibleMoves, -1, -1); // Up-left
        AddMovesInDirection(spielFeld, possibleMoves, 0, 1);  // Right
        AddMovesInDirection(spielFeld, possibleMoves, 0, -1); // Left
        AddMovesInDirection(spielFeld, possibleMoves, 1, 0);  // Down
        AddMovesInDirection(spielFeld, possibleMoves, -1, 0); // Up

        return new Pair<List<Position>, List<Position>, Int32>(possibleMoves, new List<Position>(), possibleMoves.Count);
    }
}