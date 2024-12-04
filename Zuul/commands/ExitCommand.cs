namespace Zuul;

public class ExitCommand : BasicCommand
{
    public ExitCommand(string Command) : base(Command)
    {
    }

    public override void Help(Zuul game)
    {
        Console.WriteLine("Close the Game");
    }

    public override Room Execute(string UserInput, Zuul game)
    {
        Environment.Exit(0);
        return game.currentRoom;
    }

}