// See https://aka.ms/new-console-template for more information

float z = 10.2f;
bool success = float.TryParse(Console.ReadLine(), out z);
Console.WriteLine("value = " + z);
Console.WriteLine("succes = " + success);


