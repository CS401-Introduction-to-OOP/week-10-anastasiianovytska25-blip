namespace ConsoleApp13;
using System.Collections;
using System.Collections.Generic;

public class Party: IEnumerable<Hero>
{
    private List<Hero> _heroes = new();
    public void Add(Hero c) => _heroes.Add(c);
    public IEnumerator<Hero> GetEnumerator() => _heroes.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Hero> GetActive()
    {
        foreach (var c in _heroes)
            if (c.Status == CharacterStatus.Active)
                yield return c;
    }

    public IEnumerable<Hero> GetLowHP(int b)
    {
        foreach (var c in _heroes)
            if (c.HP < b)
                yield return c;
    }

    public IEnumerable<Hero> GetByClass(string clas)
    {
            foreach (var c in _heroes)
                if (c.Class == clas)
                    yield return c;
    }    
}