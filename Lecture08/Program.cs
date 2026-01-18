// See https://aka.ms/new-console-template for more information


Player p1 = new Player();
p1.PrintInfo();

Console.WriteLine("--------------------");
Player p2 = new Player("Yossi", 0, WeaponType.Bow);
p2.SetName("Yan");

p2.PrintInfo();
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

    public Player()
    {
        this.name = "Player";
        this.hp = 100;
        this.experience = 0;
        this.weapon = new Weapon();
    }
    public  Player(string name, int weaponDamage, WeaponType type)
    {
        this.name = name;
        this.hp = 100;
        this.experience = 0;

        weapon = new Weapon(weaponDamage, type);
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

