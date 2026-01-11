// See https://aka.ms/new-console-template for more information

Player p1 = new Player();
Console.WriteLine(p1.GetGameMode());
p1.SetGameMode((GameMode)100);
Console.WriteLine(p1.GetGameMode());

enum GameMode
{
    Survival,
    Creative,
    HardCore,
    Peacefull,
    HellMode,
    MaxNUM
}

enum PlayerState
{
    Idle,
    Walking,
    Jumping
}


class Player
{
    private string name;
    private GameMode mode;
    PlayerState state;

    public void Jump()
    {
        Console.WriteLine("Jumping Yeiii");
    }

    public void SetGameMode(GameMode mode)
    {
        if (this.mode >= GameMode.MaxNUM || mode < 0)
        {
            Console.WriteLine("Invalid Mode");
            return;
        }
        this.mode = mode;
    }

    public GameMode GetGameMode()
    {
        return mode;
    }

}