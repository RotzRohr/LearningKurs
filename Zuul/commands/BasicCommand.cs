namespace Zuul;

public abstract class BasicCommand
{
    public string Command { get; set; }

    public BasicCommand(string Command)
    {
        this.Command = Command;
    }

    public abstract void Help(Zuul game);

    public abstract Room Execute(string UserInput, Zuul game);
}