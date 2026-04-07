namespace ConsoleApp13;

public class Hero
{
    public string Name { get; set; }
    public string Class { get;}
    public int Level { get;}
    public int HP { get;}
    public int Gold { get;}
    public bool IsActive { get;}

    public Hero(string name, string clas, int level, int hp, int gold, bool isActive = true)
    {
        Name = name;
        Class = clas;
        Level = level;
        HP = hp;
        Gold = gold;
        IsActive = isActive;
    }
}