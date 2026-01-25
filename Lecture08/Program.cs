// See https://aka.ms/new-console-template for more information


Console.WriteLine("--------------------");
Player p2 = new Player("Yossi", 0, WeaponType.Bow);
p2.SetName("Yan");

p2.PrintInfo();

Console.WriteLine("--------------------");
Player p3 = new Player(p2);
p3.SetName("Maayan");
p3.PrintInfo();

Console.WriteLine("--------------------");
p2.PrintInfo();

Console.WriteLine(p2.AreEqual(p3));

public enum WeaponType
{
    Axe,
    Bow,
    Crossbow,
}

public class Weapon
{
    int damage;
    public WeaponType type;

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
    public Weapon weapon;

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

    public Player(Player other)
    {
        this.name = other.name;
        this.hp = other.hp;
        this.experience = other.experience;
        this.weapon = other.weapon;
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
        this.name = name;
    }
    
    public bool AreEqual(Player other)
    {
        return (this.weapon.type == other.weapon.type);
    }
}

