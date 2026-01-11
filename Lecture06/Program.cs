// See https://aka.ms/new-console-template for more information

PlayerStats p1 = new PlayerStats();
p1.name = "Tal";
p1.health = 100;
p1.damage = 1000.0f;
p1.defense = 20.0f;
p1.playerClass = PlayerClass.Necromancer;

p1.Print();
Console.WriteLine("---------------------------");

PlayerStats p2 = new PlayerStats();
p2.name = "Maayan";
p2.health = 30;
p2.damage = 1.0f;
p2.defense = 2000.0f;
p2.playerClass = PlayerClass.Mage;

p2.Print();
Console.WriteLine("---------------------------");

p2.health = 0;
p2.Print();

Console.WriteLine("***************************");
Console.WriteLine(p1);

enum PlayerClass
{
    Necromancer,
    Mage,
    Warrior,
    Rogue,
    Summoner,
    Bard
}

struct PlayerStats
{
    public string name;
    public int health;
    public float damage;
    public float defense;
    public PlayerClass playerClass;

    public void Print()
    {
        Console.WriteLine($"Player name= {name}, health={health}, class = {playerClass}");
    }
}


/*
string playerName = Console.ReadLine();

int indexInValid;
Validate(playerName, 20, out indexInValid);
bool Validate(string str, int sizeToCheck, out int indexInValid)
{
    indexInValid = -1;

    if (str.Length > sizeToCheck)
    {
        return false;
    }

    for (int i = 0; i < str.Length; i++)
    {
        if (!IsASCII(str[i]))
        {
            indexInValid = i;
            return false;
        }
    }

    return true;
}

bool IsASCII(char c)
{
    if ((c >= 'A' && c <= 'Z') || // is upper case
        (c >= 'a' && c <= 'z')) // is lower case
        return true;

    return false;
}*/
