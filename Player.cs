namespace OOPWorkshop;

public class Player
{
    public string? playerName;
    public int level;
    public int health;

    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }
}
