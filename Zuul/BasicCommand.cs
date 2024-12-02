namespace Zuul;

public abstract class BasicCommand
{
    public string word;
    public BasicCommand(string word)
    {
        this.word = word;
    }
    public abstract void help();
    public abstract bool execute(string userInput, Room currentRoom, Program game);
}