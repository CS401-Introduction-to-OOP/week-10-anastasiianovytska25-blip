namespace ConsoleApp13;
public enum CharacterStatus { 
    Active,
    Injured,
    Dead }
public class Hero
{
    public string Name { get; set; }
    public string Class { get;}
    public int Level { get;}
    public int HP { get;}
    public int Gold { get;}
    public CharacterStatus Status { get;}
    public Hero(string name, string clas, int level, int hp, int gold, CharacterStatus status)
    {
        Name = name;
        Class = clas;
        Level = level;
        HP = hp;
        Gold = gold;
        Status = status;
    }
}