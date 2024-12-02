namespace Zuul;

public class SwitchRoom : BasicCommand
{
    public SwitchRoom(string word) : base(word)
    {
    }

    public override void help()
    {
    }

    public override bool execute(string userInput, Room currentRoom, Program game)
    {
        foreach (KeyValuePair<string, Room> currentRoomExit in currentRoom.exits)
        {
            if (currentRoomExit.Key.Equals(userInput))
            {
                game.currentRoom = currentRoomExit.Value;
                return true;
            }
        }
        return false;
    }
}