// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


Dictionary<PlayerState, float> speeds = new Dictionary<PlayerState, float>();

speeds[PlayerState.Idle] = 0;
speeds[PlayerState.Walking] = 100;
speeds[PlayerState.Running] = 200;
speeds[PlayerState.Swimming] = 50;

Player p = new Player(PlayerState.Swimming);

float currentSpeed = speeds[p.State];
Console.WriteLine("Current speed: " + currentSpeed);

p.State = PlayerState.Running;

 currentSpeed = speeds[p.State];
Console.WriteLine("Current speed: " + currentSpeed);

class Player
{
    //private PlayerState state;
    public PlayerState State { get; set; }

    public Player(PlayerState state)
    {
        this.State = state;
    }
}

enum PlayerState
{
    Idle,
    Walking,
    Running,
    Swimming
}


/*HashSet<int> ids = new HashSet<int>();

ids.Add(123456789);
//ids.Add(123456789);
ids.Add(1234567890);

if (ids.Contains(12345689))
    Console.WriteLine("Found 123456789");

//ids.Remove(123456789);

Utiltiy.PrintCollection(ids);

//Utiltiy.PrintAmount(ids);

*/
static class Utiltiy
{
    public static void PrintAmount(HashSet<int> ids)
    {
        Console.WriteLine("Count: " + ids.Count + 
                          " Capacity: " + ids.Capacity);
        
        Console.WriteLine("-----------------------------");

    }

    public static void PrintCollection(HashSet<int> ids)
    {
        foreach (var id in ids)
        {
            Console.WriteLine(id);
        }
    }
}

/*List<Enemy> enemies = new List<Enemy>();
Utiltiy.PrintAmount(enemies);

enemies.Add(new Enemy("Maayan", 1000));
Enemy e = new Enemy("Yan", 0);
enemies.Add(e);

Utiltiy.PrintAmount(enemies);

enemies.Add(new Enemy("Maayan", 1000));
enemies.Add(new Enemy("Yan", 0));
enemies.Add(new Enemy("Maayan", 1000));

Utiltiy.PrintAmount(enemies);

//enemies.Clear();
//enemies.TrimExcess();

enemies.Insert(2, new Enemy("Dekel", 123));
if (enemies.Contains(e))
{
    Console.WriteLine("Found Yan");
}

Utiltiy.PrintAmount(enemies);

class Enemy
{
    private string name;
    private int damage;

    public Enemy(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}

static class Utiltiy
{
    public static void PrintAmount(List<Enemy> enemies)
    {
        Console.WriteLine("Count: " + enemies.Count + 
                          " Capacity: " + enemies.Capacity);
        
        Console.WriteLine("-----------------------------");

    }
}

*/