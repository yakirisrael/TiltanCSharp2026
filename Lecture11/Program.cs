// See https://aka.ms/new-console-template for more information

using System.Text.Json;
string path = Environment.CurrentDirectory + "../../../../SaveFiles/MyGame.sav";

Item itm1 = new Item { Name = "Staff", Amount = 2 };
Player p1 = new Player { Name = "Dekel", Hp = 67, Level = 30, item = itm1 };

/*using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
{
    using (BinaryWriter bw = new BinaryWriter(fs))
    {
        bw.Write(p1.item.Name);
        bw.Write(p1.Name);
        bw.Write(p1.Hp);
        bw.Write(p1.Level);
    }
    
}*/

Player NewPlayer = new Player();
NewPlayer.item = new Item();

FileStream fs = null;

try
{
        fs = new FileStream(path, FileMode.Open, FileAccess.Read);

        using (BinaryReader br = new BinaryReader(fs))
        {
            NewPlayer.item.Name = br.ReadString();
            NewPlayer.Name = br.ReadString();
            NewPlayer.Hp = br.ReadSingle();
            NewPlayer.Level = br.ReadInt32();

        }
}
catch (Exception e)
{
    Console.WriteLine("We are handling the crash here, message" + e.Message);

}

finally
{
    if (fs != null)
    {
        fs.Close();
        Console.WriteLine("closing the file");
    }
    else
    {
        Console.WriteLine("file not exist");
    }
}


/*



string newContent = File.ReadAllText(path);
Console.WriteLine(newContent);
Player playerFromFile = JsonSerializer.Deserialize<Player>(newContent);
Console.ReadKey();
*/
//string personSerialized = JsonSerializer.Serialize(p1);
//Console.WriteLine(personSerialized);
//File.WriteAllText(path, personSerialized);


string content = "This is my game, copyrights resereved to Jon Battelfield";

/*
using (StreamReader reader = new StreamReader(path))
{
    bool matchStopSymnbol = false;
    while (!matchStopSymnbol)
    {
        string line = reader.ReadLine();
        Console.WriteLine(line);
        matchStopSymnbol = line.Contains(",");
    }
}*/
/*File.WriteAllText(path, content);
File.AppendAllText(path, " appending Text");
string readFromFile = File.ReadAllText(path);
Console.WriteLine(readFromFile);
*/
//Console.WriteLine("Path: " + Environment.CurrentDirectory);



class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
}

class Player
{
    public string Name { get; set; }
    public float Hp { get; set; }
    public int Level { get; set; }
    
    public Item item { get; set; }
}