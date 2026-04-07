namespace ConsoleApp13;
using System.Collections;
using System.Collections.Generic;

public class EventLog : IEnumerable<Event>
{
    private List<Event> events = new();
    public void Add(Event e) => events.Add(e); 
    public IEnumerator<Event> GetEnumerator() => events.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerable<Event> GetByType(EventType type)
    {
        foreach (var e in events)
            if (e.Type == type)
                yield return e;
    }
    public IEnumerable<Event> GetLastActions(int n)
    {
        for (int i = Math.Max(0, events.Count - n); i < events.Count; i++)
            yield return events[i];
    }
    
}

