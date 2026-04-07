namespace ConsoleApp13;

public class Event
{
    public int Turn { get;}
    public string Description { get;}
    public string Type { get;}
    public string Effect { get;}

    public Event(int turn, string description, string type, string effect)
    {
        Turn = turn;
        Description = description;
        Type = type;
        Effect = effect;
    }
}