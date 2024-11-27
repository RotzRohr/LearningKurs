using Schachspiel.data;

namespace Schachspiel.firguren;

public class SpielFeld
{
    public Dictionary<string, Figur?> felder = new Dictionary<string, Figur?>();

    public SpielFeld()
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                felder.Add(i.ToString()+j.ToString(), null);
            }
        }

        for(int i = 0; i < 8; i++)
        {
            felder[1.ToString()+i.ToString()] = new Bauer(new Position(1, i), Player.BLACK);
            felder[6.ToString()+i.ToString()] = new Bauer(new Position(6, i), Player.WHITE);
        }

        //set Könige
        felder[0.ToString()+4.ToString()] = new Koenig(new Position(0, 4), Player.BLACK);
        felder[7.ToString()+4.ToString()] = new Koenig(new Position(7, 4), Player.WHITE);

        //set Läufer
        felder[0.ToString()+2.ToString()] = new Laeufer(new Position(0, 2), Player.BLACK);
        felder[0.ToString()+5.ToString()] = new Laeufer(new Position(0, 5), Player.BLACK);
        felder[7.ToString()+2.ToString()] = new Laeufer(new Position(7, 2), Player.WHITE);
        felder[7.ToString()+5.ToString()] = new Laeufer(new Position(7, 5), Player.WHITE);

        //set Türme
        felder[0.ToString()+0.ToString()] = new Turm(new Position(0, 0), Player.BLACK);
        felder[0.ToString()+7.ToString()] = new Turm(new Position(0, 7), Player.BLACK);
        felder[7.ToString()+0.ToString()] = new Turm(new Position(7, 0), Player.WHITE);
        felder[7.ToString()+7.ToString()] = new Turm(new Position(7, 7), Player.WHITE);


        //set Damen
        felder[0.ToString()+3.ToString()] = new Dame(new Position(0, 3), Player.BLACK);
        felder[7.ToString()+3.ToString()] = new Dame(new Position(7, 3), Player.WHITE);

        //set Springer
        felder[0.ToString()+1.ToString()] = new Springer(new Position(0, 1), Player.BLACK);
        felder[0.ToString()+6.ToString()] = new Springer(new Position(0, 6), Player.BLACK);
        felder[7.ToString()+1.ToString()] = new Springer(new Position(7, 1), Player.WHITE);
        felder[7.ToString()+6.ToString()] = new Springer(new Position(7, 6), Player.WHITE);
    }

    /**
     -------------------------
|T2|S2|L2|K2|D2|L2|S2|T2|
-------------------------
|B2|B2|B2|B2|B2|B2|B2|B2|
-------------------------
|  |  |  |  |  |  |  |  |
-------------------------
|  |  |  |  |  |  |  |  |
-------------------------
|  |  |  |  |  |  |  |  |
-------------------------
|  |  |  |  |  |  |  |  |
-------------------------
|B1|B1|B1|B1|B1|B1|B1|B1|
-------------------------
|T1|S1|L1|D1|K1|L1|S1|T1|
-------------------------
     */
    private static string seperatorLine = "-------------------------";
    public void PrintSpielFeld()
    {
        Console.WriteLine("   " + string.Join(" ", Enumerable.Range(0, 8).Select(n => n.ToString().PadLeft(2))));
        Console.WriteLine("  " + seperatorLine);

        for (int i = 0; i < 8; i++)
        {
            Console.Write(i + " ");  // Print row number
            for (int j = 0; j < 8; j++)
            {
                Figur? figur = felder[i.ToString() + j.ToString()];
                if (figur == null)
                {
                    Console.Write("|  ");
                }
                else
                {
                    Console.Write("|" + figur.getSpielFeldSymbol());
                }
            }
            Console.WriteLine("|");
            Console.WriteLine("  " + seperatorLine);
        }
    }


    public Figur? GetFigur(Position position)
    {
        return felder[position.ToString()];
    }

    public bool StillInField(Position position)
    {
        return position.X >= 0 && position.X < 8 && position.Y >= 0 && position.Y < 8;
    }

    public void TakeTurn(Player player)
    {
        Console.WriteLine("Spieler " + player + " ist am Zug.");
        Console.WriteLine("Du kannst folgende Figuren bewegen:");
        Figur?[] bewegbareFiguren = felder.Values.Where(figur => figur != null && figur.player == player && figur.getPossibleMoves(this).Third > 0).ToArray();
        for (int i = 0; i < bewegbareFiguren.Length; i++)
        {
            Console.WriteLine(i+1 + ": " + bewegbareFiguren[i].getSpielFeldSymbol() + " | Position: " + bewegbareFiguren[i].currentPosition);
        }

        Console.WriteLine("Welche Figur möchtest du bewegen?");
        int figureIndex = -1;
        while (true)
        {
            figureIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (figureIndex >= 0 && figureIndex < bewegbareFiguren.Length)
            {
                break;
            }
        }

        Figur selectedFigur = bewegbareFiguren[figureIndex];
        Console.WriteLine("Du hast die Figur " + selectedFigur.getSpielFeldSymbol() + " auf Position " + selectedFigur.currentPosition + " ausgewählt.");

        Pair<List<Position>,List<Position>, Int32> moves = selectedFigur.getPossibleMoves(this);
        if(moves.First.Count > 0)
        {
            Console.WriteLine("Mögliche Züge:");
            moves.First.ForEach(pos => Console.WriteLine(pos));
        }
        if(moves.Second.Count > 0)
        {
            Console.WriteLine("Mögliche Schlag Züge:");
            moves.Second.ForEach(pos => Console.WriteLine(pos));
        }

        Console.WriteLine("Wohin möchtest du die Figur bewegen?");
        Position newPosition = null;
        while (true)
        {
            string input = Console.ReadLine();
            newPosition = new Position(Convert.ToInt32(input[0].ToString()), Convert.ToInt32(input[1].ToString()));
            if (moves.First.Contains(newPosition) || moves.Second.Contains(newPosition))
            {
                break;
            }
        }
        Position currentPosition = selectedFigur.currentPosition;
        felder[currentPosition.ToString()] = null;
        felder[newPosition.ToString()] = selectedFigur;
        selectedFigur.currentPosition = newPosition;
    }
}