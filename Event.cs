namespace ConsoleApp13;
public enum EventType { Battle,
    Loot, 
    Quest, 
    Heal }
public class Event
{
    public int Turn { get;}
    public string Description { get;}
    public EventType Type { get;}
    public string Effect { get;}
    public Event(int turn, string description, EventType type, string effect)
    {
        Turn = turn;
        Description = description;
        Type = type;
        Effect = effect;
    }
}