namespace Zuul;

public class GoCommand : BasicCommand
{
    public GoCommand(string Command) : base(Command)
    {
    }

    public override void Help(Zuul game)
    {
        Console.WriteLine("Move to specific RoominGame ex.: 'go left'");
    }

    public override Room Execute(string UserInput, Zuul game)
    {
        if (game.currentRoom.Exits.Keys.Contains(UserInput))
        {
            return game.currentRoom.Exits[UserInput];
        }
        else
        {
            return game.currentRoom;
        }
    }
}