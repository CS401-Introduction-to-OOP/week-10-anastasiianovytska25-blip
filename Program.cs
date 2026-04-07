using System;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            var party = new Party();
            party.Add(new Hero("Levi", "Warrior", 15, 40000, 100, CharacterStatus.Active));
            party.Add(new Hero("Legolas", "Archer", 4, 30, 50, CharacterStatus.Active));
            party.Add(new Hero("Eren", "Warrior", 3, 13300, 20, CharacterStatus.Injured));

            var log = new EventLog();
            log.Add(new Event(1, "Battle with titans", EventType.Battle, "-10 HP"));
            log.Add(new Event(2, "Treasure", EventType.Loot, "+50 Gold"));
            log.Add(new Event(3, "Completed", EventType.Quest, "+100 XP"));
            log.Add(new Event(4, "Healer", EventType.Heal, "+20 HP"));
            foreach (var h in party)
                Console.WriteLine(h);
            foreach (var h in party.GetActive())
                Console.WriteLine(h);
            foreach (var h in party.GetLowHP(20))
                Console.WriteLine(h);
            foreach (var h in party.Where(h => h.Level >= 4))
                Console.WriteLine(h);
            Console.WriteLine($"Hero with max gold: {party.Max(h => h.Gold)}");
            Console.WriteLine($"Number of injured heroes: {party.Count(h => h.Status == CharacterStatus.Injured)}");
            foreach (var e in log)
                Console.WriteLine(e);

            foreach (var e in log.GetByType(EventType.Battle))
                Console.WriteLine(e.Description);
            foreach (var e in log.GetLastActions(2))
                Console.WriteLine(e);
        }
    }
}