namespace Schachspiel.data;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Position p = (Position)obj;
        return (X == p.X) && (Y == p.Y);
    }

    public override string ToString()
    {
        return X.ToString()+Y.ToString();
    }
}