// See https://aka.ms/new-console-template for more information

Console.WriteLine(Player.GetPlayerId());
Player p1 = new Player();
p1.PrintInfo();


Console.WriteLine(Player.GetPlayerId());


Console.WriteLine("--------------------");
Player p2 = new Player("Yossi", 0, WeaponType.Bow);
p2.SetName("Yan");

p2.PrintInfo();

Console.WriteLine(Player.GetPlayerId());

public enum WeaponType
{
    Axe,
    Bow,
    Crossbow,
}

class Weapon
{
    int damage;
    WeaponType type;

    public Weapon()
    {
        damage = 10;
        type = WeaponType.Axe;
    }
    public Weapon(int damage, WeaponType type)
    {
        this.damage = damage;
        this.type = type;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"damage: {this.damage}");
        Console.WriteLine($"type: {this.type}");
    }
}

public class Player
{
    private string name;
    private int hp;
    private int experience;
    private Weapon weapon;

    private static int id = 100;

    public static int GetPlayerId()
    {
        return id;
    }

    public Player()
    {
        this.name = "Player";
        this.hp = 100;
        this.experience = 0;
        this.weapon = new Weapon();

        float height = 10;
        float weight = 20;

        double heightPow = Math.Pow((double)height, 2);
        float bmi = weight / (float)heightPow;
        float speed = 30 - bmi;

        id++;
    }
    public  Player(string name, int weaponDamage, WeaponType type)
    {
        this.name = name;
        this.hp = 100;
        this.experience = 0;

        weapon = new Weapon(weaponDamage, type);

        id++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"HP: {this.hp}");
        Console.WriteLine($"Experience: {this.experience}");

        this.weapon.PrintInfo();
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        if (name == "Yan") return;
        this.name = name;
    }
}

