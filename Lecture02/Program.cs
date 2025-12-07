// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

bool b = true;
bool c = false;
bool d = c || b;

int z = 15;
int t = 30;
bool l = z >= t;
Console.WriteLine(z >= t);


if (z > 5)
{
    Console.WriteLine("greater than 5");

    if (t < 2) Console.WriteLine("lower than 2");
    
    Console.WriteLine("THIS LINE");
    
}
else
{
    Console.WriteLine("not greater than 5");
}